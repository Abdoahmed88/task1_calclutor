using System;
using System.Diagnostics.CodeAnalysis;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,sum;
            string op;
            Console.Write("Enter the first numper :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose Arithmetic operators + , - , * , / ");
            op = Console.ReadLine();
            Console.Write("Enter the second numper :");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case "+":
                    sum =num1 + num2;
                    Console.WriteLine("the sum is :\a" + sum);
                    break;
                case "-":
                    sum = num1 - num2;
                    Console.WriteLine("the sum is :\a" + sum);
                    break;
                case "*":
                    sum = num1 * num2;
                    Console.WriteLine("the sum is :\a" + sum);
                    break;
                case "/":
                    sum = num1 / num2;
                    Console.WriteLine("the sum is :\a" + sum);
                    break;



            }
        }
    }
}