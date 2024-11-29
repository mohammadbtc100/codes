pub mod fibo{
    pub fn fibo_algo_recursive(mut n: u32) -> u32 {
        match n {
            0 => panic!("Zero is not a Right argument"),
            1 => 0,
            2 => 1,
            _ => fibo_algo_recursive(n-1)+fibo_algo_recursive(n-2)
        }
    }
}