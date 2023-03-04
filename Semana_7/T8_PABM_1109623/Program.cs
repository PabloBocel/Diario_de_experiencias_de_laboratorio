using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_PABM_1109623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = "";
            while (!menu.Contains("d"))
            {
                Console.WriteLine("laboratorio 8"); // Pablo Bocel
                Console.WriteLine("Ingrese una opción a-d");
                Console.WriteLine("a. sumatoria"+ "\nb. Mostrar tablas de multiplicar"+"\nc. Número perfecto"+"\nd. Salir del programa");
                string letra = Console.ReadLine();
                Console.Clear();

                switch (letra)
                {
                    case "a":
                        Console.WriteLine("Sumatoria");
                        int suma = 0;
                        int num = 0;
                        int i = 1; 
                        Console.WriteLine("Escribe un número");
                        num = Convert.ToInt32(Console.ReadLine());

                        do
                        {

                            if (num > 0)
                            {
                                suma = suma + i;
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número mayor a 0");
                            }
                            
                           
                        }
                        while (i <= num);
                        Console.WriteLine("La sumatoria es "+suma);

                        Console.ReadKey();
                        Console.Clear();
                        break; 
                        case "b":
                        Console.WriteLine("Mostrar tablas de multpilicar");
                        Console.WriteLine("Ingrese un número");
                        int num2 = 0;
                           num2  = Convert.ToInt32(Console.ReadLine()); 

                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine(j * num2);
                        }

                        Console.ReadKey();
                        Console.Clear(); 
                        break; 
                        case "c":
                        Console.WriteLine("Número perfecto");
                        Console.WriteLine("Ingrese un número mayor a 0");
                        int num3 = 0;
                        num3 = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        int h = sum;

                        
                            if (num3 > 0)
                            {
                            for (int l = 1; l < num3; l++)
                            {
                                if (num3 % l == 0)
                                {
                                    sum = sum + l;
                                }
                                
                            }
                            if (sum == num3)
                            {
                                Console.WriteLine(num3 + " es un numero perfecto");
                            }
                            else
                            {
                                Console.WriteLine("no es un numero perfecto");
                            }
                            }
                            
                        Console.ReadKey();
                        Console.Clear();
                        break; 
                        case "d":

                        menu = ("d");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
