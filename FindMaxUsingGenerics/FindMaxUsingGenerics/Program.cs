using System;

namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            Maximum max = new Maximum();
            int maxNumber = max.ReturnMaxNumber(num1, num2, num3);
            Console.WriteLine("max number is " + maxNumber);



        }
    }
}