using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01_Calculator
{
    public class Calculator
    {
        public static int Add(params int[] values)
        {
            int length = values.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = values[i] + sum;
            }
           return sum;
        }

        public static int Subtract(params int[] values)
        {
            int length = values.Length;
            int sum = values[0];
            for (int i = 1; i < length; i++)
            {
                sum = sum - values[i];
            }
            return sum;
        }

        public static object Sum(params int[] values)
        {
            int length = values.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = values[i] + sum;
            }
            return sum;
        }

        public static int Multiply(params int[] values)
        {
            int length = values.Length;
            int sum = values[0];
            for (int i = 1; i < length; i++)
            {
                sum = values[i] * sum;
            }
            return sum;
        }

        public static double Power(int Base, int Expo)
        {
            return Math.Pow(Base, Expo);
        }

        public static int Factorial(int Fact)
        {
            int sum = Fact;
            for (int i = Fact - 1; i > 0; i--)
            {
                sum = sum * i;
            }
            return sum;
        }

    }
}
