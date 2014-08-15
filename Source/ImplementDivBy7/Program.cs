using System;

namespace ImplementDivBy7
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
             
            while (true)
            {
                int input = 0;
                int divisor = 0;
                int counter = 0;
                Console.WriteLine("Enter number for division.");
                input = int.Parse(Console.ReadLine());
                divisor = input;
                while(divisor-7 >= 0)
                {
                    divisor= divisor - 7;
                    counter = counter + 1;
                }
                 Console.WriteLine("You can divide {0} by seven, {1} times with a remainder of {2}.", input, counter, divisor);
                break;
            }
        }
    }
}
