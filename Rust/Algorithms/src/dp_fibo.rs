pub mod fibo{
    //Non-Recursive
    pub fn fibo_algo_non_recursive(n:u32,print:bool) -> u32{
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
}