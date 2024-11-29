//Mohammad Ahmadzadeh


fn main() {
    let n=8;
    //Series printing
    let mut value = fibo(n, true);
    println!("\nFibo({0}) last Term is {1}",n,value);

    value = fibonacci(n);
    println!("Fibonacci({0}): {1}", n,value);
}
