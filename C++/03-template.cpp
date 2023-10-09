//Template example
//Author : Mohammad Ahmadzadeh
#include <iostream>
using namespace std;

template <typename T>
class Calculation {
    private:
        int n;
    public:
        Calculation() {
            n = 0;
        }
        
        void print();

        T fact(T n) {
            T s = 1;
            for (T i = 1; i <= n; i++)
                s *= i;
            //access to global variable
            Calculation::n =s;
            return s;
        }
};

template <typename T> void Calculation<T>::print() {
    cout << "fn value : " << n << endl;
}

template<typename P> P getMax(P x, P y) {
    P z = (x >= y) ? x : y;
    return z;
}

int main()
{
    Calculation<int> calc = Calculation<int>();
    int c = calc.fact(5);
    cout <<"Fact : "<< c << "\n";
    calc.print();

    c = getMax<int>(8.4, 4.6);
    cout << "Max  : " << c << "\n";

}
