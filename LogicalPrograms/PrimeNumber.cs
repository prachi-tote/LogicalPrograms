using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void PrimeNum()
        {
            int n, i, m = 0, flag = 0;

            n = int.Parse(Console.ReadLine());
            m = n / 2 ;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{n} is not Prime Number");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write($"{n} is Prime Number");

        }
    
    }
    }
