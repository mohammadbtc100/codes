using System;
using System.Runtime.InteropServices;

class Program
{
    // Importing the Add function from the Rust library
    [DllImport("rust_library.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int add(int a, int b);

    // Importing the Subtract function from the Rust library
    [DllImport("rust_library.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int subtract(int a, int b);

    static void Main()
    {
        int num1 = 10;
        int num2 = 5;

        // Call the Add function
        int sum = add(num1, num2);
        Console.WriteLine($"Sum: {sum}"); // Output: Sum: 15

        // Call the Subtract function
        int difference = subtract(num1, num2);
        Console.WriteLine($"Difference: {difference}"); // Output: Difference: 5
    }
}
