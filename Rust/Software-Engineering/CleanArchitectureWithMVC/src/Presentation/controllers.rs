use actix_web::{web, HttpResponse};
use crate::application::services::create_user;
use crate::domain::models::User;
use crate::presentation::views::UserView;

pub async fn create_user_handler(user: web::Json<User>, pool: web::Data<crate::infrastructure::db::DbPool>) -> HttpResponse {
    match create_user(&pool, user.into_inner()).await {
        Ok(created_user) => {
            let user_view = UserView::from_user(&created_user);
            HttpResponse::Created().json(user_view)
        },
        Err(err) => HttpResponse::InternalServerError().body(err),
    }
}
