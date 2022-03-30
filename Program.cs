using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR12_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SR 12 Build a calculator by using conditional and Switch statement
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Calculator Console");

            Console.WriteLine("Input a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine()); //User input number

            Console.WriteLine("Input another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine()); //User input number

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("+ - Add");
            Console.WriteLine("- - Subtract");
            Console.WriteLine("* - Multiply");
            Console.WriteLine("/ - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine()) //User input number manipulation option
            {
                case "+": //Addition
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-": //Subtraction
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*": //Multiplication
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/": //Division
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.ReadKey(); //focus


        }
        
    }
}
