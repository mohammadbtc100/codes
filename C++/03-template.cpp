#include <iostream>
using namespace std;
template <typename T>
class Calculation {
    public:
        T fact(T n) {
            T s = 1;
            for (T i = 1; i <= n; i++)
                s *= i;
            return s;
        }
};

template<typename P> P getMax(P x, P y) {
    P z = (x >= y) ? x : y;
    return z;
}

int main()
{
    Calculation<int> calc = Calculation<int>();
    int c = calc.fact(5);
    cout <<"Fact : "<< c << "\n";

    c = getMax<int>(8.4, 4.6);
    cout << "Max  : " << c << "\n";

}
