using System;
using System.Diagnostics.Metrics;
using System.Text;

namespace PrimeNumbers
{
    class Program
    {
        static void Main()
        {
            int n1, n2, i, j;

            Console.WriteLine(" Enter any Starting Number of range : ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any Ending Number Of range : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between {0} and {1} are : \n", n1, n2);

            for (i = n1; i <= n2; i++)
            {

                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                }


                if (i == j)
                    Console.WriteLine(i);

            }

        }

    }

}
