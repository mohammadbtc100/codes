using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_RoslynApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            const string programText = @"
        using System;

        namespace HelloWorld
        {
            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine(""Hello, World!"");
                }
            }
        }";

            // Parse the code into a syntax tree
            SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
            CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

            // Analyze the syntax tree
            Console.WriteLine("Namespaces in the program:");
            foreach (var ns in root.Members.OfType<NamespaceDeclarationSyntax>())
            {
                Console.WriteLine(ns.Name.ToString());
            }

            // Generate new code
            var newMethod = SyntaxFactory.MethodDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), "NewMethod")
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                .WithBody(SyntaxFactory.Block(
                    SyntaxFactory.SingletonList<StatementSyntax>(
                        SyntaxFactory.ExpressionStatement(
                            SyntaxFactory.ParseExpression(@"Console.WriteLine(""New Method Called!"")")
                        )
                    )
                ));

            // Add the new method to the Program class
            var programClass = root.DescendantNodes()
                                   .OfType<ClassDeclarationSyntax>()
                                   .FirstOrDefault(c => c.Identifier.Text == "Program");

            var newClass = programClass.AddMembers(newMethod);

            // Replace old class with new class in the root
            var updatedRoot = root.ReplaceNode(programClass, newClass);

            Console.WriteLine("\nUpdated Code:\n");
            Console.WriteLine(updatedRoot.ToFullString());

            Console.ReadKey();  

            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }
}
