//tokio = { version = "1.18", features = ["full"] }

use tokio; // Import the tokio library for asynchronous programming
#[tokio::main] // Macro to define the main function as an asynchronous function
async fn main() {
    let task1 = async_task("Task 1", 2); // Create an asynchronous task
    let task2 = async_task("Task 2", 3); // Create another asynchronous task

    // Wait for both tasks to complete
    let (result1, result2) = tokio::join!(task1, task2);

    println!("Results: {}, {}", result1, result2); // Print the results
}

// Function that simulates an asynchronous task
async fn async_task(name: &str, duration: u64) -> String {
    println!("{} is starting...", name);
    tokio::time::sleep(tokio::time::Duration::from_secs(duration)).await; // Sleep for a specified duration
    format!("{} is done!", name) // Return the result
}
