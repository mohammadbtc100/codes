// Add this to your Cargo.toml
// [dependencies]
// reqwest = { version = "0.11", features = ["tokio", "json"] }
// tokio = { version = "1", features = ["full"] }

use reqwest;
use std::fs::File;
use std::io::{self, Write};

#[tokio::main]
async fn main() {
    // URL of the file to download
    let url = "https://news-cdn.varzesh3.com/pictures/2024/12/12/D/4bkvfboo8.jpg?w=791"; // Replace with the actual file URL
    let output_filename="Kenan-Yıldız.jpg";
    let response = reqwest::get(url).await.expect("Failed to send request");

    // Create a file to save the downloaded content
    let mut out = File::create(output_filename).expect("Failed to create file");

    // Copy the response body into the file
    let mut content = response.bytes().await.expect("Failed to read response bytes");
    out.write_all(&content).expect("Failed to write content");

    println!("File downloaded successfully!");
}
