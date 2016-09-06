using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01_Calculator
{
    class Calculator
    {
        internal static int Add(params int[] values)
        {
            int length = values.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = values[i] + sum;
            }
           return sum;
        }

        internal static int Subtract(params int[] values)
        {
            int length = values.Length;
            int sum = values[0];
            for (int i = 1; i < length; i++)
            {
                sum = sum - values[i];
            }
            return sum;
        }

        internal static object Sum(int[] values)
        {
            int length = values.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = values[i] + sum;
            }
            return sum;
        }

        internal static int Multiply(params int[] values)
        {
            int length = values.Length;
            int sum = values[0];
            for (int i = 1; i < length; i++)
            {
                sum = values[i] * sum;
            }
            return sum;
        }

        internal static double Power(int Base, int Expo)
        {
            return Math.Pow(Base, Expo);
        }

        internal static int Factorial(int Fact)
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
