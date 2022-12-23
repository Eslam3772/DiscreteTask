using System;
using System.Diagnostics.Metrics;
using System.Text;

namespace PerfectNumbers
{
    class Program
    {
        static void Main()
        {

            int n1, n2, i, j, sum;
            Console.Write("enter the start number ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("enter the end number ");
            n2 = int.Parse(Console.ReadLine());

            for(j=n1;j<=n2;j++)
            {

                i = 1;
                sum = 0;
                while(i<j)
                {

                    if (j % i == 0)
                        sum += i;
                    i++;
                }















                if (sum == j)
                Console.WriteLine(j);

            }
           
        }

    }

}
