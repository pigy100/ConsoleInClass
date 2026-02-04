using System;

namespace ConsoleInClass
{

    internal class Program
    {
        static double Sqrt(int num)
        {
            if (num < 0)
                throw new ArgumentException("The number must be positive");
            return (Math.Sqrt(num));
        }
        static void Main(string[] args)
        {
            /*try
            {
                Console.Write("Enter the number please: ");
                int num = int.Parse(Console.ReadLine());
                num = num + 3;
                Console.WriteLine("Result is:" + num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error You Dumb, "+ex.Message);
            }






            try
            {
                Console.Write("Enter number:");
                int num = int.Parse(Console.ReadLine());
                num = 10 / num;
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("The value must be numeric");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero:");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thanks for the input");
            }




            try { Sqrt(-5); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }*/

        }
    }
}
