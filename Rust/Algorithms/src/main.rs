mod fibo;
use fibo;

fn main() {
    fibo::fibonacci(5);
    let n=8;
    let value:u32;
    //Series printing
    //let mut value = fibo(n, true);
    //println!("\nFibo({0}) last Term is {1}",n,value);

    value = fibo::fibonacci(n);
    println!("Fibonacci({0}): {1}", n,value);
}
