use actix_web::{web, App, HttpServer, HttpResponse, Responder};
use rusqlite::{Connection, Result as SqliteResult};
use serde::{Deserialize, Serialize};

#[derive(Serialize, Deserialize)]
struct Todo {
    id: Option<i32>,
    title: String,
    completed: bool,
}

fn create_table(conn: &Connection) -> SqliteResult<()> {
    conn.execute(
        "CREATE TABLE IF NOT EXISTS todos (
            id INTEGER PRIMARY KEY,
            title TEXT NOT NULL,
            completed BOOLEAN NOT NULL
        )",
        [],
    )?;
    Ok(())
}

async fn get_todos(data: web::Data<Connection>) -> impl Responder {
    let conn = data.get_ref();
    let mut stmt = conn.prepare("SELECT id, title, completed FROM todos").unwrap();
    let todos = stmt.query_map([], |row| {
        Ok(Todo {
            id: Some(row.get(0)?),
            title: row.get(1)?,
            completed: row.get(2)?,
        })
    }).unwrap();

    let todos: Vec<Todo> = todos.map(|t| t.unwrap()).collect();
    HttpResponse::Ok().json(todos)
}

async fn create_todo(todo: web::Json<Todo>, data: web::Data<Connection>) -> impl Responder {
    let conn = data.get_ref();
    let result = conn.execute(
        "INSERT INTO todos (title, completed) VALUES (?1, ?2)",
        &[&todo.title, &todo.completed.to_string()],
    );

    match result {
        Ok(_) => HttpResponse::Ok().body("Todo created successfully"),
        Err(_) => HttpResponse::InternalServerError().body("Failed to create todo"),
    }
}

#[actix_web::main]
async fn main() -> std::io::Result<()> {
    let conn = Connection::open("todos.db").expect("Failed to open database");
    create_table(&conn).expect("Failed to create table");

    HttpServer::new(move || {
        App::new()
            .app_data(web::Data::new(conn.clone()))
            .route("/", web::get().to(|| HttpResponse::Ok().body("Welcome to the Todo API!")))
            .route("/todos", web::get().to(get_todos))
            .route("/todos", web::post().to(create_todo))
    })
    .bind("127.0.0.1:8080")?
    .run()
    .await
}
