using FindMaxUsingGenerics;
using System;

namespace FindMaxUsingGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Program that want to be executed : \n 1. Find Maximum Integer \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First number, Second number, Third number : ");
                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        int third = Convert.ToInt32(Console.ReadLine());
                        int result = MaximumSolution.FindMax(first, second, third);
                        Console.WriteLine("Maximum Number is : " + result);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
