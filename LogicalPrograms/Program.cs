// See https://aka.ms/new-console-template for more information
using System;
namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("Welcome to Fibonacci Program");
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.Fibonac();
        }
    }
}
