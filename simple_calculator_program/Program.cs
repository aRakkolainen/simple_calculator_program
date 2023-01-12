using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator_program
{
    internal class Program
    {
        static int Choice()
        {
            Console.WriteLine("Operations for this simple calculator: ");
            Console.WriteLine("1) Calculate addition of two integers");
            Console.WriteLine("2) Calculate substraction of two integers");
            Console.WriteLine("3) Calculate multiplication of two integers");
            Console.WriteLine("4) Calculate division of two integers");
            //Console.WriteLine("5) Calculate power of some number");
            Console.WriteLine("0) Exit the program");
            Console.Write("Give your choice (0 ends the program): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your choice: " + choice);
            Console.WriteLine("");
            return choice; 
        }
        static int GiveNumber()
        {
            Console.Write("Give a number: ");
            int number = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("You gave number: " + number);
            return number; 
        }
        static void Main(string[] args)
        {
            //int choice = Choice();
            while  (true)
            {
                int choice = Choice();
                if (choice == 1)
                {
                    Console.WriteLine("Calculating the addition of two numbers");
                    int num1 = GiveNumber();
                    int num2 = GiveNumber();
                    int result = num1 + num2;
                    Console.WriteLine("Result of addition: " + result);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Calculating the substraction of two numbers");
                    int num1 = GiveNumber();
                    int num2 = GiveNumber();
                    int result = num1 - num2;
                    Console.WriteLine("Result of substraction: " + result);

                }
                else if (choice == 3)
                {
                    Console.WriteLine("Calculating the multiplication of two numbers");
                    int num1 = GiveNumber();
                    int num2 = GiveNumber();
                    int result = num1 * num2;
                    Console.WriteLine("Result of multiplication: " + result);
                } else if (choice == 4)
                {
                    Console.WriteLine("Calculating the division of two numbers");
                    int num1 = GiveNumber();
                    int num2 = GiveNumber();
                    if (num2 != 0)
                    {
                        int result = num1 / num2;
                        Console.WriteLine("Result of division: " + result);
                    } else
                    {
                        Console.WriteLine("It is not possible to divide with 0!, give new number!");
                        num2 = GiveNumber();
                        int result = num1 / num2;
                        Console.WriteLine("Result of division: " + result);
                    }
                
                } else if (choice == 0) {
                    break; 
                }// else if (choice == 5)
                //{
                  //  Console.WriteLine("Calculating the power of some number");
                //}
                else
                    {
                        Console.WriteLine("Unknown choice, try again.");
                    }
            }
            
            
        
 
        }
    }
}
