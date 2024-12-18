using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculation
{

    // Token types
    public enum TokenType
    {
        Number,
        Plus,
        Minus,
        Multiply,
        Divide,
        EOF // End of file/input
    }

    // Token representation
    public class Token
    {
        public TokenType Type { get; }
        public string Value { get; }

        public Token(TokenType type, string value)
        {
            Type = type;
            Value = value;
        }
    }

    // Lexer to tokenize the input string
    public class Lexer
    {
        private readonly string _text;
        private int _pos;
        private char _currentChar;

        public Lexer(string text)
        {
            _text = text;
            _pos = 0;
            _currentChar = _text[_pos];
        }

        private void Advance()
        {
            _pos++;
            if (_pos >= _text.Length)
                _currentChar = '\0'; // Indicates end of input
            else
                _currentChar = _text[_pos];
        }

        private void SkipWhitespace()
        {
            while (_currentChar != '\0' && char.IsWhiteSpace(_currentChar))
                Advance();
        }

        private Token Number()
        {
            var result = "";
            while (_currentChar != '\0' && char.IsDigit(_currentChar))
            {
                result += _currentChar;
                Advance();
            }
            return new Token(TokenType.Number, result);
        }

        public Token GetNextToken()
        {
            while (_currentChar != '\0')
            {
                if (char.IsWhiteSpace(_currentChar))
                {
                    SkipWhitespace();
                    continue;
                }

                if (char.IsDigit(_currentChar))
                    return Number();

                if (_currentChar == '+')
                {
                    Advance();
                    return new Token(TokenType.Plus, "+");
                }

                if (_currentChar == '-')
                {
                    Advance();
                    return new Token(TokenType.Minus, "-");
                }

                if (_currentChar == '*')
                {
                    Advance();
                    return new Token(TokenType.Multiply, "*");
                }

                if (_currentChar == '/')
                {
                    Advance();
                    return new Token(TokenType.Divide, "/");
                }

                throw new Exception($"Invalid character: {_currentChar}");
            }

            return new Token(TokenType.EOF, null);
        }
    }

    // AST Node for numbers
    public class NumberNode
    {
        public Token Token { get; }

        public NumberNode(Token token)
        {
            Token = token;
        }
    }

    // AST Node for binary operations
    public class BinaryOperationNode
    {
        public NumberNode Left { get; }
        public Token Operator { get; }
        public NumberNode Right { get; }

        public BinaryOperationNode(NumberNode left, Token operatorToken, NumberNode right)
        {
            Left = left;
            Operator = operatorToken;
            Right = right;
        }
    }

    // Parser to create an AST from tokens
    public class Parser
    {
        private readonly Lexer _lexer;
        private Token _currentToken;

        public Parser(Lexer lexer)
        {
            _lexer = lexer;
            _currentToken = _lexer.GetNextToken();
        }

        private void Eat(TokenType tokenType)
        {
            if (_currentToken.Type == tokenType)
                _currentToken = _lexer.GetNextToken();
            else
                throw new Exception($"Unexpected token: {_currentToken.Value}");
        }

        public BinaryOperationNode Parse()
        {
            var left = new NumberNode(_currentToken);
            Eat(TokenType.Number);

            var operatorToken = _currentToken;
            Eat(operatorToken.Type);

            var right = new NumberNode(_currentToken);
            Eat(TokenType.Number);

            return new BinaryOperationNode(left, operatorToken, right);
        }
    }

    // Evaluator to compute the result of the AST
    public class Evaluator
    {
        public int Evaluate(BinaryOperationNode node)
        {
            int leftValue = int.Parse(node.Left.Token.Value);
            int rightValue = int.Parse(node.Right.Token.Value);

            switch (node.Operator.Type)
            {
                case TokenType.Plus:
                    return leftValue + rightValue;
                case TokenType.Minus:
                    return leftValue - rightValue;
                case TokenType.Multiply:
                    return leftValue * rightValue;
                case TokenType.Divide:
                    return leftValue / rightValue;
                default:
                    throw new Exception("Invalid operator");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an expression (e.g., 3 + 5): ");
            string input = Console.ReadLine();

            Lexer lexer = new Lexer(input);
            Parser parser = new Parser(lexer);

            try
            {
                BinaryOperationNode ast = parser.Parse();
                Evaluator evaluator = new Evaluator();

                int result = evaluator.Evaluate(ast);

                Console.Write($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
