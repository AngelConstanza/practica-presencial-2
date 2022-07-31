using System;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            int num2 = int.Parse(Console.ReadLine());
            var suma = num1 + num2;
            Console.WriteLine("La suma de los numeros es: {0}", suma);
        }
    }
}
