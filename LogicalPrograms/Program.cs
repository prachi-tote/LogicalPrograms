// See https://aka.ms/new-console-template for more information
using System;
namespace LogicalPrograms
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Logical Problem!");
                Console.WriteLine("Prime Number Program");
            Console.WriteLine("Enter a number to chek weather it is prime or not:");
            PrimeNumber primeNumber = new PrimeNumber();
                primeNumber.PrimeNum();
            }
        }
    }

