using System;

namespace FindMaxUsingGeneric
{
    class Program<T> where T : IComparable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1st value:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter 2nd value");
            int b=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter 3rd value");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("=====================");

            int[] intArray=new int[] {a,b,c};
            char[] charArray = new char[] { 'w', 'j', 'k' };
            double[] doubleArray = new double[] {2.5,3.1,4.2};

            MaxOf3 mx = new MaxOf3();
            mx.FindMax(intArray);
        }
        public class MaxOf3
        {
            public void FindMax(int[] inputArray)
            {
                if (inputArray[0]>inputArray[1]&& inputArray[0] > inputArray[2])
                {
                    Console.WriteLine(inputArray[0]+" is maximum");
                }
                else if(inputArray[1] > inputArray[2]&& inputArray[1] > inputArray[0])
                {
                    Console.WriteLine(inputArray[1] + " is maximum");
                }
                else
                {
                    Console.WriteLine(inputArray[2] + " is maximum");
                }

            }
        }
    }
}

