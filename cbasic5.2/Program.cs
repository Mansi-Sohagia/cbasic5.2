/* 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
 */

using System;

namespace BasicCSharpExcercise5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int SUM = 0;
            while (true)
            {
                Console.WriteLine("Enter Number: ");
                var n = Console.ReadLine();
                if (n == "ok")
                    break;
                var numbers = Convert.ToInt32(n);
                SUM += numbers;
            }
            Console.WriteLine("sum= " + SUM);
        }
    }
}
