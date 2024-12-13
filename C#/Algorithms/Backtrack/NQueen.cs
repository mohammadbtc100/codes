using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Backtrack
{
    public class NQueen
    {
        static int N = 8; // You can change this to any value of N
        // Function to solve the N-Queens problem
        public void SolveNQueens(int n)
        {
            int[,] board = new int[n, n];
            if (PlaceQueens(board, 0))
            {
                PrintBoard(board);
            }
            else
            {
                Console.WriteLine("No solution exists.");
            }
        }

        // Recursive function to place queens on the board
        public bool PlaceQueens(int[,] board, int row)
        {
            if (row >= board.GetLength(0)) // All queens are placed
                return true;

            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (IsSafe(board, row, col))
                {
                    board[row, col] = 1; // Place queen

                    // Recur to place the rest of the queens
                    if (PlaceQueens(board, row + 1))
                        return true;

                    // If placing queen in this position doesn't lead to a solution,
                    // remove queen (backtrack)
                    board[row, col] = 0;
                }
            }

            return false; // Trigger backtracking
        }

        // Function to check if it's safe to place a queen at board[row][col]
        public bool IsSafe(int[,] board, int row, int col)
        {
            // Check this column on upper side
            for (int i = 0; i < row; i++)
                if (board[i, col] == 1)
                    return false;

            // Check upper diagonal on left side
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1)
                    return false;

            // Check upper diagonal on right side
            for (int i = row, j = col; i >= 0 && j < board.GetLength(1); i--, j++)
                if (board[i, j] == 1)
                    return false;

            return true; // Safe to place queen
        }

        // Function to print the chessboard
        public void PrintBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] == 1 ? " Q " : " . ");
                }
                Console.WriteLine();
            }
        }
    }
}
