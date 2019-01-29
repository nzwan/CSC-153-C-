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

            int num1 = 10;
            bool isAlive = false;

            //if (isAlive == true)
            //{
            //    Console.WriteLine("Your Alive!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Your Dead!!!");
            //}

            //if (num1 < 15)
            //{
            //    Console.WriteLine("num is less than 3");
            //}
            //else if (num1 < 12)
            //{
            //    Console.WriteLine("num is greater than 2 less than 7");
            //}
            //else if (num1 < 3)
            //{
            //    Console.WriteLine("num is greater than 6 less than 15");
            //}
            //else
            //{
            //    Console.WriteLine("Not in range");
            //}

            isAlive = false;

            //if (num1 > 0 && num1 < 10)
            //{
            //    Console.WriteLine("This number is between 0 and 10");
            //}

            //if(isAlive == true && num1 > 5)
            //{
            //    Console.WriteLine("This works!");
            //}

            //if (isAlive == false || num1 > 5)
            //{
            //    Console.WriteLine("This Works too!");
            //}

            //if (!(num1 < 10))
            //{
            //    Console.WriteLine("this will work fine");
            //}

            //if (isAlive == true)

            //{
            //    if (num1 == 10)
            //    {
            //        Console.WriteLine($"Youre alive and {num1} years old");
            //        Console.WriteLine("Change num1 to 9");


            //    }
            //    else
            //    {
            //        Console.WriteLine($"Youre alive and {num1} years old");
            //        Console.WriteLine("Change isAlive to false");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("This can go on."); 
            //}

            switch (num1) //Conditionals not allowed looking for an exact match!
            {
                case 5:
                    Console.WriteLine("The number is 5");
                    break;
                case 10:
                    Console.WriteLine("The number is 10");
                    break;
                default:
                    Console.WriteLine("Not Sure");
                    break;


            }
                
            


            Console.ReadLine();
        }

    }
}
