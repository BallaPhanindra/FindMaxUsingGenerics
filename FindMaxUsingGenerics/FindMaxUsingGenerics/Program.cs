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
                Console.WriteLine("Enter the Program that want to be executed : \n 1. Find Maximum Integer \n 2. Find Maximum Float \n 3. Exit");
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
                        Console.WriteLine("Enter First number, Second number, Third number to check : ");
                        double firstNum = Convert.ToDouble(Console.ReadLine());
                        double secondNum = Convert.ToDouble(Console.ReadLine());
                        double thirdNum = Convert.ToDouble(Console.ReadLine());
                        double res = MaximumSolution.FindMax(firstNum, secondNum, thirdNum);
                        Console.WriteLine("The Maximum Number is : " + res);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
