using System;
using System.Diagnostics.CodeAnalysis;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,sum;
            string op;
            Console.Write("Enter The First Numper : ");
            num1 =Convert.ToInt16( Console.ReadLine());
            Console.Write("Enter The second Numper : ");
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("choose Arithmetic operators + , - , * , / ");
            op = Console.ReadLine();
            if (op=="+")
            {
                sum = num1 + num2;
                Console.Write("the sum is :" + sum);
            }
            else if (op=="-")
            {
                sum = num1 - num2;
                Console.Write("the sum is :" + sum);
            }
            else if (op == "*")
            {
                sum = num1 * num2;
                Console.Write("the sum is :" + sum);
            }
            else if (op == "/")
            {
                sum = num1 / num2;
                Console.Write("the sum is :" + sum);
            }

        }
    }
}