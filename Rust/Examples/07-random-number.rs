use rand::Rng; // Import the Rng trait for random number generation
//rand = "0.8"
// Function to generate a random number in the specified range
fn generate_random_number(min: u32, max: u32) -> u32 {
    let mut rng = rand::thread_rng(); // Create a random number generator
    rng.gen_range(min..=max) // Generate a random number in the range [min, max]
}

fn main() {
    let min = 1; // Minimum value (inclusive)
    let max = 100; // Maximum value (inclusive)

    for i in 1..10{
        // Generate a random number and print it
        let random_number = generate_random_number(min, max);
        println!("Random number between {} and {}: {}", min, max, random_number);
    }
}
