using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the calculator");
                Console.WriteLine("Choose a calculation (1-6) and separate arguments with comma");
                Console.WriteLine("Write 0 to quit");
                int hello = Int32.Parse(Console.ReadLine());
                Console.WriteLine(hello);
                if (hello > -1 && hello < 7)
                {
                    switch (hello)
                    {
                        case 1:
                            Console.WriteLine("Add, give any number of arguments");
                            Console.WriteLine(Calculator.Add(multiArg(Console.ReadLine())));
                            break;
                        case 2:
                            Console.WriteLine("Subtract, give any number of arguments");
                            Console.WriteLine(Calculator.Subtract(multiArg(Console.ReadLine())));
                            break;
                        case 3:
                            Console.WriteLine("Multiply, give any number of arguments");
                            Console.WriteLine(Calculator.Multiply(multiArg(Console.ReadLine())));
                            break;
                        case 4:
                            Console.WriteLine("Sum, give any number of arguments");
                            Console.WriteLine(Calculator.Sum(multiArg(Console.ReadLine())));
                            break;
                        case 5:
                            Console.WriteLine("Power, give 2 arguments");
                            Console.WriteLine(Calculator.Power(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
                            break;
                        case 6:
                            Console.WriteLine("Factorial, give one argument");
                            Console.WriteLine(Calculator.Factorial(Int32.Parse(Console.ReadLine())));
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                Console.WriteLine("wrong input, try again");
                Console.ReadLine();
            }
        }
        public static int[] multiArg(string myString)
        {
            List<string> stringArray = myString.Split(',').ToList<string>();
            int[] n1 = new int[stringArray.Count];
            int tempInt = 0;
            foreach (string element in stringArray)
            {
                n1[tempInt] = Int32.Parse(element);
                tempInt++;
            }
            return n1;
        }
            
    }
}
