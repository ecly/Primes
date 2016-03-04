using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = new List<int> { 2 };

            for (int i = 3; i < int.MaxValue; i++)
            {
                var isPrime = true;
                foreach (int j in primes)
                {
                    if (i % j == 0) {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                    Console.WriteLine("Found prime number: " + i);
                }
            }
        }
    }
}
