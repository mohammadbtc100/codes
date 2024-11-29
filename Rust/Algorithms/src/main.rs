//Mohammad Ahmadzadeh

//Non-Recursive
fn fibo(n:u32,print:bool) -> u32{
    let mut i=3;
    let mut a:u32=0;
    let mut b:u32=1;
    let mut c:u32 = 1;
    if print== true {
        print!("Fibo Series : {0} {1} ",a,b);
    }
    while i<=n {
        c=a+b;
        if print== true{
            print!("{} ",c);
        }
        a=b;
        b=c;
        i=i+1;
    }
    c
}
//Recursive
fn fibonacci(mut n: u32) -> u32 {
    match n {
        0 => panic!("Zero is not a Right argument"),
        1 => 0,
        2 => 1,
        _ => fibonacci(n-1)+fibonacci(n-2)
    }
}
fn main() {
    let n=8;
    //Print Series
    let mut value = fibo(n, true);
    println!("\nFibo({0}) last Term is {1}",n,value);

    value = fibonacci(n);
    println!("Fibonacci({0}): {1}", n,value);
}
