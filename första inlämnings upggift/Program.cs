using System;

namespace första_inlämnings_upggift
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("input the first number to multiply");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("input the second number to multiply");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("input the third number to multiply");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("output: {0} x {1} x {2}= {3}", num1, num2, num3, result);



        }

        private static string NewMethod()
        {
            return Console.ReadLine();
        }
    }
}
