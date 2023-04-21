// See https://aka.ms/new-console-template for more information
using System;
namespace LogicalPrograms
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Logical Problem!");
                Console.WriteLine("Reverse Number Program");
                Console.WriteLine("Enter a number which you want to reverse");
                ReverseNumber reverseNumber = new ReverseNumber();
                reverseNumber.Reverse();
            }
        }
    }

