using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void ReverseNum()
        {
            int number, rem = 0, reverse = 0;
            Console.WriteLine("Enter the Number You want to reverse");
            number =Convert.ToInt32(Console.ReadLine());
           
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("The Reverse of the Given Number is {0}", reverse)
;        }
    }
}
