using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to be reversed");
            int number = Convert.ToInt32(Console.ReadLine()); // The input number needs to be converted from a string to an int in order to use it in a formula
            int reverseNum = 0;        //I need to define the number that will be the output for the console
            while (number > 0)         //The formula that i found won't work with a negative number so I need a loop to make sure that the number is positive before we use it
            {
                int numberTwo = number % 10;
                reverseNum = (reverseNum * 10) + numberTwo;
                number = number / 10;
                // I found this forumula online that gives us the reverse number
            }
            Console.WriteLine("The reverse of your number is={0}",reverseNum);
            Console.ReadLine();
        }
    }
}
