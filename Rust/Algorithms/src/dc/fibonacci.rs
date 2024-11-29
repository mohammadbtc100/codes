mod fibo{
    pub fn fibonacci(mut n: u32) -> u32 {
        match n {
            0 => panic!("Zero is not a Right argument"),
            1 => 0,
            2 => 1,
            _ => fibonacci(n-1)+fibonacci(n-2)
        }
    }
}