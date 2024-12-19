using System;
using Python.Runtime;

class Program
{
    //Install-Package pythonnet
    static void Main(string[] args)
    {
        // Set the Python DLL path
        Runtime.PythonDLL = "python313.dll"; // Adjust based on your Python version
        PythonEngine.Initialize();

        using (Py.GIL()) // Acquire the Global Interpreter Lock
        {
            dynamic scope = Py.CreateScope();
            scope.Exec("def add(a, b): return a + b"); // Define a Python function

            int result = scope.add(5, 10); // Call the Python function
            Console.WriteLine($"Result from Python: {result}");
        }

        PythonEngine.Shutdown(); // Clean up
        Console.ReadKey();
    }
}
