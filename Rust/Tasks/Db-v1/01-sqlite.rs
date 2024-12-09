use rusqlite::{Connection, Result};
/*
Skill National university, Mohammad Ahmadzadeh
[dependencies]
rusqlite = { version = "0.29.0", features = ["bundled"] }
*/
#[derive(Debug)]
struct Person {
    id: i32,
    name: String,
    age: i32,
}

fn main() -> Result<()> {
    let conn = Connection::open("my_database.db")?;

    // Create table
    conn.execute(
        "CREATE TABLE IF NOT EXISTS person (
            id INTEGER PRIMARY KEY,
            name TEXT NOT NULL,
            age INTEGER
        )",
        [],
    )?;

    // Create (Insert)
    conn.execute(
        "INSERT INTO person (name, age) VALUES (?1, ?2)",
        ["Alice", "30"],
    )?;

    // Read
    let mut stmt = conn.prepare("SELECT id, name, age FROM person")?;
    let person_iter = stmt.query_map([], |row| {
        Ok(Person {
            id: row.get(0)?,
            name: row.get(1)?,
            age: row.get(2)?,
        })
    })?;

    for person in person_iter {
        println!("Found person {:?}", person.unwrap());
    }

    // Update
    conn.execute(
        "UPDATE person SET age = ?1 WHERE name = ?2",
        ["21","Alice"],
    )?;

    // Delete
    //conn.execute("DELETE FROM person WHERE name = ?1", ["Alice"])?;

    Ok(())
}
