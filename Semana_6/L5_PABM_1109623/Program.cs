using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_PABM_1109623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // goto ejercicio1;
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("\nIngresa un número entero"); //enteros positvos y negativos
            string numString = Console.ReadLine();
            int numero = 0;
            bool canConvert = int.TryParse(numString, out numero);

            if (canConvert == true)
            {
                if (numero == 0)
                {
                    Console.WriteLine("Numero es cero");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Numero entero negativo");
                }
                else if (numero > 0)
                {
                    Console.WriteLine("Numero entero positivo");
                }
            }
            else
            {
                Console.WriteLine("Usted ingresó una letra");
            }
            //ejercicio2:
            // este es el ejercicio 2
            Console.WriteLine("\nEjercicio 2");
            Console.WriteLine("Ingrese el número de día");
            int dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Día: Lunes");
                    break;
                case 2:
                    Console.WriteLine("Día: Martes");
                    break;
                case 3:
                    Console.WriteLine("Día: Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Día: Jueves");
                    break;
                case 5:
                    Console.WriteLine("Día: Viernes");
                    break;
                case 6:
                    Console.WriteLine("Día: Sábado");
                    break;
                case 7:
                    Console.WriteLine("Día: Domingo");
                    break;
                default:
                    Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
                    break;
            }

            Console.ReadKey();
        }
    }
}

