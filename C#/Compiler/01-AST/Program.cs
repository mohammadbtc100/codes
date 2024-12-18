using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace _01_AST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string programText = @"
            using System;

            namespace HelloWorld
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        Console.WriteLine(""Hello World!"");
                    }
                }
            }";

            // Parse the code into a syntax tree
            SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
            CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

            // Display the root node
            Console.WriteLine(root.ToFullString());


            // Print the structure of the AST
            PrintSyntaxNode(root, 0);
            Console.ReadKey();  
        }
        static void PrintSyntaxNode(SyntaxNode node, int indent)
        {
            Console.WriteLine(new string(' ', indent) + node.Kind());

            foreach (var child in node.ChildNodes())
            {
                PrintSyntaxNode(child, indent + 2);
            }
        }
    }
}
