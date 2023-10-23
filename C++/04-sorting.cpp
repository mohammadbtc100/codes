#include<iostream>
#include<cstdlib>
using namespace std;

class Sorting {
public: 
	Sorting() {};
	void randomArray(int a[], int len);
	void print(string message, int a[], int len);
	void bubbleSort(int *a, int len,string sort="asc");
};
void Sorting::print(string message, int a[], int len) {
	cout << message;
	for (int i = 0; i < len; i++) {
		cout << a[i] << "  ";
	}
	cout << endl;
}
void Sorting::bubbleSort(int *a, int len, string sort) {
	int t;
	for (int i = 0; i < len; i++)
		for (int j = 0; j < len; j++)
			if (sort == "asc") {
				if (a[i] < a[j]) {
					t = a[i];
					a[i] = a[j];
					a[j] = t;
				}
			}
			else if (sort == "desc") {
				if (a[i] > a[j]) {
					t = a[i];
					a[i] = a[j];
					a[j] = t;
				}
			}
			else
				exit(-1);
}
void Sorting::randomArray(int a[], int len) {
	int n;
	srand(time(0));
	for (int i = 0; i < len; i++) {
		n = rand() % 100;
		a[i] = n;
	}
}
int main() {
	const int n = 10;
	int a[n];
	Sorting arrayObj = Sorting();
	arrayObj.randomArray(a,n);
	arrayObj.print("Array    : ",a, n);

	arrayObj.bubbleSort(a, n);
	arrayObj.print("ASC msg  : ",a, n);

	arrayObj.bubbleSort(a, n,"desc");
	arrayObj.print("DESC msg : ",a, n);
	
	return 0;
}

