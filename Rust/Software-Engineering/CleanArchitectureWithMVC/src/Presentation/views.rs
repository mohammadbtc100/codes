use serde::{Serialize};

#[derive(Serialize)]
pub struct UserView {
    pub id: i32,
    pub name: String,
    pub email: String,
}

impl UserView {
    pub fn from_user(user: &crate::domain::models::User) -> Self {
        UserView {
            id: user.id,
            name: user.name.clone(),
            email: user.email.clone(),
        }
    }
}
