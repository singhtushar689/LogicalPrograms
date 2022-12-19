using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumbers
    {
        public void Prime()
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("{0} is not a prime Number ", number);
                    return;
                }
            }    
                {
                    Console.WriteLine("{0} is a prime Number", number);
                }
            
        }
        
    }
}
