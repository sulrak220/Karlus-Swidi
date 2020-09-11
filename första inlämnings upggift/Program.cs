using System;

namespace första_inlämnings_upggift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("operator");
            string operator1 = Console.ReadLine();
            Console.WriteLine("operator 2");
            string operator2 = Console.ReadLine();
            Console.WriteLine("term 1");
            int term1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("term 2");
            int term2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("term 3");
            int term3 = Convert.ToInt32(Console.ReadLine());

            if (operator1 == "+" && operator2 == "+")
            {
                int sum = term1 + term2 + term3;
                Console.WriteLine(sum);
            }
            else if (operator1 == "+" && operator2 == "-")
            {
                int sum = term1 + term2 - term3;
                Console.WriteLine(sum);

            }
            else if (operator1 == "+" && operator2 == "*")
            {
                int sum = term1 + (term2 * term3);
                Console.WriteLine(sum);

            }
            else if (operator1 == "+" && operator2 == "/")
            {
                int sum = (term1 + term2) / term3;
                Console.WriteLine(sum);
            }


            if (operator1 == "-" && operator2 == "+")
            {
                int sum = term1 - term2 + term3;
                Console.WriteLine(sum);
            }
            else if (operator1 == "-" && operator2 == "-")
            {
                int sum = term1 - term2 - term3;
                Console.WriteLine(sum);

            }
            else if (operator1 == "-" && operator2 == "*")
            {
                int sum = term1 - (term2 * term3);
                Console.WriteLine(sum);

            }
            else if (operator1 == "-" && operator2 == "/")
            {
                int sum = (term1 - term2) / term3;
                Console.WriteLine(sum);
            }


            if (operator1 == "*" && operator2 == "+")
            {
                int sum = (term1 * term2) + term3;
                Console.WriteLine(sum);
            }
            else if (operator1 == "*" && operator2 == "-")
            {
                int sum = (term1 * term2) - term3;
                Console.WriteLine(sum);

            }
            else if (operator1 == "*" && operator2 == "*")
            {
                int sum = term1 * term2 * term3;
                Console.WriteLine(sum);

            }
            else if (operator1 == "*" && operator2 == "/")
            {
                int sum = (term1 * term2) / term3;
                Console.WriteLine(sum);
            }

            if (operator1 == "/" && operator2 == "+")
            {
                int sum = term1 / (term2 + term3);
                Console.WriteLine(sum);
            }
            else if (operator1 == "/" && operator2 == "-")
            {
                int sum = term1 / (term2 - term3);
                Console.WriteLine(sum);

            }
            else if (operator1 == "/" && operator2 == "*")
            {
                int sum = term1 / (term2 * term3);
                Console.WriteLine(sum);

            }
            else if (operator1 == "/" && operator2 == "/")
            {
                int sum = term1 / term2 / term3;
                Console.WriteLine(sum);
            }


        }

    }
}
