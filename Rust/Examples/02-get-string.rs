use std::io::stdin;

fn main(){
    let mut string = String::new();

    eprint!("Enter A String :");
    let b1 = stdin().read_line(&mut string);

    println!("Entred String  : {}", string);
}