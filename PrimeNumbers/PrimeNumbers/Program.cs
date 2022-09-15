using System.Diagnostics;
using System.Globalization;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            for (int i = 3; i < 15485863; i+=2)
            {
                bool isPrime = true;
                int max = (int)Math.Sqrt(i);
                
                for (int j = 3; j <= max; j+=2)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    //Console.WriteLine(i);
                    primes.Add(i);
                }
            }
 
        }
    }
}