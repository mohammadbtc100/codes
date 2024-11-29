pub mod dc_fibo;
pub mod dp_fibo;
use crate::dc_fibo::fibo::fibo_algo_recursive;
use crate::dp_fibo::fibo::fibo_algo_non_recursive;
pub mod fibonacci {
    pub fn execute(n:u32,print:bool) {
        //let n=8;
        let mut value:u32;
        value = fibo_algo_recursive(n);
        println!("\nFibo({0}) last Term is {1}",n,value);

        value = fibo_algo_non_recursive(n,print);
        println!("\nFibonacci({0}): {1}", n,value);
    }
}