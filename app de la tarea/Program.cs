using System;

namespace app_de_la_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            int num2 = int.Parse(Console.ReadLine());
            var resta = num1 - num2;
            Console.WriteLine("La resta de los numeros es: {0}", resta);
        }
    }
}
