use actix_web::{web, App, HttpResponse, HttpServer, Responder};
use serde::{Deserialize, Serialize};
use std::sync::Mutex;

#[derive(Serialize, Deserialize, Clone)]
struct Student {
    id: u32,
    name: String,
    score: f32,
}

struct ScoreService {
    students: Mutex<Vec<Student>>,
}

impl ScoreService {
    fn new() -> Self {
        ScoreService {
            students: Mutex::new(vec![
                Student { id: 1, name: "Alice".to_string(), score: 85.5 },
                Student { id: 2, name: "Bob".to_string(), score: 92.0 },
            ]),
        }
    }

    async fn get_all_scores(&self) -> impl Responder {
        let students = self.students.lock().unwrap();
        HttpResponse::Ok().json(&*students)
    }

    async fn get_student_score(&self, student_id: u32) -> impl Responder {
        let students = self.students.lock().unwrap();
        match students.iter().find(|&s| s.id == student_id) {
            Some(student) => HttpResponse::Ok().json(student),
            None => HttpResponse::NotFound().body("Student not found"),
        }
    }

    async fn add_student_score(&self, student: Student) -> impl Responder {
        let mut students = self.students.lock().unwrap();
        students.push(student);
        HttpResponse::Created().json(&students.last().unwrap())
    }

    async fn update_student_score(&self, student_id: u32, new_score: f32) -> impl Responder {
        let mut students = self.students.lock().unwrap();
        if let Some(student) = students.iter_mut().find(|s| s.id == student_id) {
            student.score = new_score;
            HttpResponse::Ok().json(student)
        } else {
            HttpResponse::NotFound().body("Student not found")
        }
    }
}

struct AppState {
    score_service: ScoreService,
}

async fn get_all_scores(data: web::Data<AppState>) -> impl Responder {
    data.score_service.get_all_scores().await
}

async fn get_student_score(path: web::Path<u32>, data: web::Data<AppState>) -> impl Responder {
    let student_id = path.into_inner();
    data.score_service.get_student_score(student_id).await
}

async fn add_student_score(student: web::Json<Student>, data: web::Data<AppState>) -> impl Responder {
    data.score_service.add_student_score(student.into_inner()).await
}

async fn update_student_score(path: web::Path<u32>, new_score: web::Json<f32>, data: web::Data<AppState>) -> impl Responder {
    let student_id = path.into_inner();
    data.score_service.update_student_score(student_id, new_score.into_inner()).await
}

#[actix_web::main]
async fn main() -> std::io::Result<()> {
    let app_state = web::Data::new(AppState {
        score_service: ScoreService::new(),
    });
    println!("127.0.0.1:8080");
    HttpServer::new(move || {
        App::new()
            .app_data(app_state.clone())
            .route("/scores", web::get().to(get_all_scores))
            .route("/scores/{id}", web::get().to(get_student_score))
            .route("/scores", web::post().to(add_student_score))
            .route("/scores/{id}", web::put().to(update_student_score))
    })
        .bind("127.0.0.1:8080")?
        .run()
        .await
}
