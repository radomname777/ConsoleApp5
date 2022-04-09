using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double num1, num2;
        static void setnum1()
        {
            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
        }
        static void setnum2()
        {
            Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        static double sum() { return num1 + num2; }
        static double minus() { return num1 - num2; }
        static double Multiplication() { return num1 * num2; }
        static double Division()
        {
            while (num2==0)
            {
                Console.WriteLine("Cannot divide by zero!!!");
                setnum2();
            }
            return num1 / num2;
        }
        static void selsymbols()
        {
            while (true)
            {
                setnum1(); setnum2();
                Console.WriteLine("Select the symbol\n+\t -\n/\t * \t e)exit");
                var symbol = Console.ReadLine().ToUpper();
                switch (symbol)
                {
                    case "+":
                        Console.WriteLine(sum());
                        break;
                    case "-":
                        Console.WriteLine(minus());
                        break;
                    case "/":
                        Console.WriteLine(Division());
                        break;
                    case "*":
                        Console.WriteLine(Multiplication());
                        break;
                    case "E":
                        return;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            selsymbols();
        }
    }
}