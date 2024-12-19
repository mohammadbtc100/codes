using System;
using System.Runtime.InteropServices;

class Program
{
    // Import the add function from the example.dll
    [DllImport("example.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int add(int a, int b);

    static void Main(string[] args)
    {
        int result = add(5, 10); // Call the C function
        Console.WriteLine($"Result from C: {result}"); // Output: Result from C: 15
    }
}
