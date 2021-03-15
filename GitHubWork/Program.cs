using System;

namespace GitHubWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 0, b= 0;

            Console.WriteLine("Ingrese un valor para a: ");
            a = Int32.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese un valor para b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"La resta de {a} - {b} es igual a {SubtractNumbers(a,b) }");
        }

        public static int SubtractNumbers(int a, int b)
        {

            return a - b;
        }

    }
}
