using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2 = 10.5, num3;
            double double1, double2;
            decimal decimal1;
            int num4;

            //int x = num2; Does not work
            //Console.WriteLine(x);

            int wholeNumber;
            decimal moneyNumber = 4500.50m;
            wholeNumber = (int)moneyNumber;

            Console.WriteLine(wholeNumber);

            double realNumber;
            realNumber = (double)moneyNumber;
            Console.WriteLine(realNumber);

            realNumber = 50.14;
            moneyNumber = (decimal)realNumber;
            Console.WriteLine(moneyNumber);

            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            //Console.Write("Enter your name. > ");
            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            //Console.Write("Enter an double. >");
            //string input = Console.ReadLine();

            //if(int.TryParse(input, out double1))
            //{
            //    Console.Write($"Your Interger is {num4} ");

            //}
            //else
            //{
            //    Console.Write("Not an double!");

            //}


            //Console.Write("Enter an interger. >");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out num4))
            //{
            //    Console.Write($"Your Interger is {num4}");

            //}
            //else
            //{
            //    Console.Write("Not an interger!");
            //}


            Console.Write("Enter an decimal. >");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal1))
            {
                Console.Write($"Your decimal is {decimal1} ");

            }
            else
            {
                Console.Write("Not a decimal!");
            }

            Console.ReadLine();

          

          

        }
    }
}
