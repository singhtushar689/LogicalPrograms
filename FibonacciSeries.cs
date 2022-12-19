using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b + " ");
            //Console.WriteLine(b + " ");
            for(int i = 2; i <= number; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b + " " );
            }
        }
    }
}
