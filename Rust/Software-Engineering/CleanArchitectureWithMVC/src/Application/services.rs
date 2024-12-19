use crate::domain::models::User;
use crate::infrastructure::db::DbPool;
use diesel::prelude::*;
use diesel::r2d2::{self, ConnectionManager};

pub async fn create_user(pool: &DbPool, user: User) -> Result<User, String> {
    let conn = pool.get().map_err(|_| "Failed to get connection from pool")?;

    // Example pseudo-code for inserting into the database:
    // let new_user = diesel::insert_into(users)
    //     .values(&user)
    //     .get_result(&conn)
    //     .map_err(|_| "Error inserting user")?;

    Ok(user) // Return the created user for view conversion.
}
