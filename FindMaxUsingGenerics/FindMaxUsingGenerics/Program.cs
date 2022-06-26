using System;
using System.Collections.Generic;

namespace FindMaxUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");

            int[] intArray = { 3, 8, 6, 1, 4, };
            double[] doubleArray = { 1.2, 1.8, 3.2, 2.8, 7.9 };
            String[] stringArray = { "12", "24", "56", "34", "89" };

            new GenericMaximum<int>(intArray).PrintMaxValue();
            new GenericMaximum<double>(doubleArray).PrintMaxValue();
            new GenericMaximum<string>(stringArray).PrintMaxValue();

        }
    }
}