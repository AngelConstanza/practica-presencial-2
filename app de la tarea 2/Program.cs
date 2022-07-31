using System;

namespace app_de_la_tarea_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un numero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            int num2 = int.Parse(Console.ReadLine());
            var multiplicaciòn = num1 * num2;
            Console.WriteLine("La multiplicacion de los numeros es: {0}", multiplicaciòn);

        }
        
        }
    }

