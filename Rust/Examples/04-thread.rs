use std::thread;
use std::time::Duration;

fn main() {
    // Create a vector to hold the thread handles
    let mut handles = vec![];

    // Spawn 10 threads
    for i in 0..10 {
        // Create a new thread
        let handle = thread::spawn(move||{
            // Each thread will sleep for a duration and then print its number
            thread::sleep(Duration::from_millis(100));
            println!("Thread number: {}", i);
        });
        // Store the handle to join later
        handles.push(handle);
    }

    // Wait for all threads to finish
    for handle in handles {
        handle.join().unwrap();
    }

    println!("All threads have completed.");
}
