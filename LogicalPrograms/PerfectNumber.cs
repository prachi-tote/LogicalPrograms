﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
 {
    internal class PerfectNumber
    {

        public void PerfectNum()
            {
                Console.WriteLine("Enter the number");
                int n = int.Parse(Console.ReadLine());
                int number = n;
                int factor = 1;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (number % i == 0)
                    {
                        factor += i;
                    }
                }
                if (factor == n)
                {
                    Console.WriteLine($"{n} is a Perfect number");
                }
                else
                {
                    Console.WriteLine($"{n} is  not a perfect number");
                }
            }
        }
    }
