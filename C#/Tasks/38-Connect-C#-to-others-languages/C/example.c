// example.c
#include <stdio.h>

__declspec(dllexport) int add(int a, int b) {
    return a + b;
}
