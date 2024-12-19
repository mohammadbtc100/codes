use actix_web::{web, App, HttpServer};
use dotenv::dotenv;
use std::env;

mod domain;
mod application;
mod infrastructure;
mod presentation;

#[actix_web::main]
async fn main() -> std::io::Result<()> {
    dotenv().ok();

    let pool = infrastructure::db::establish_connection();

    HttpServer::new(move || {
        App::new()
            .app_data(web::Data::new(pool.clone()))
            .route("/users", web::post().to(presentation::controllers::create_user_handler))
    })
        .bind(format!("127.0.0.1:8080"))?
        .run()
        .await
}
