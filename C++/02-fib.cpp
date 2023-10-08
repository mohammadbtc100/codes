//Author : Mohammad Ahmadzadeh
#include <iostream>

//fibo class
class Calculation {
public:
    int fibonacci(int n) {
        
        if (n < 0)
            throw -1;

        if (n == 1)
            return 0;
        else if (n == 2 || n == 3)
            return 1;
        else {
            int a = 0, b = 1, c = 1,i=4;
            a = 1; //because i started from 4
            while (i <= n) {
                c = a + b;
                a = b;
                b = c;
                i++;
            }
            return c;
        }
    }
};

//main function
int main()
{
    std::cout << "Fibonacci\n";
    Calculation calc =Calculation();
    int n = 10;
    if (n < 0)
        std::cout << "The entred value is incorrect\n";
    else {
        int fn;
        for (int i = 1; i <= n; i++) {
            fn = calc.fibonacci(i);
            std::cout << i<< " = " << fn << "\n";
        }
    }

}
