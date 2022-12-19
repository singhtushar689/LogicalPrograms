using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public  class PerfectNumber
    {
        public void PerfectNum()
        {
            int number, divisor;
            
            Console.WriteLine("Enter the Min Range");
            int min =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the Max Range");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perfect Number Within the given Range ");
           
            for(number = min; number <= max; number++)
            {
                divisor = 1;
                int sum = 0;
               
                while(divisor < number)
                {
                    if(number % divisor == 0)
                    {
                        sum = sum + divisor;      
                    }
                     divisor++;
                } 
                if(sum == number)
                {
                    Console.WriteLine (sum);
                }
            }
        }
    }
}
