using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_PABM_1109623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 1: operaciones aritméticas"); //se definen las variables 
            int n1;
            int n2;
            int suma = 0;
            int resta = 0;
            int mult =  0;
            int div = 0;
            int mod = 0;
            bool mayor = false;
            bool menor = false;
            bool igual = false;
            double n3;
            double n4;
            double n5;
            double i = 0;
            double ii = 0;
            double iii = 0;
            double iv = 0;
            //el programa pide los dos numeros que se utilizaran para las operaciones

            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese un numero");
            n2= int.Parse(Console.ReadLine());

            suma = n1 + n2;        //se utilizan las variables para las operaciones y se muestran en pantalla gracias al console.readline
            Console.WriteLine(n1+ " + "+n2 +" = "+ suma);
            resta = n1 - n2;
            Console.WriteLine(n1 + " - " + n2 + " = " + resta);
            mult = n1 * n2;
            Console.WriteLine(n1 + " * " + n2 + " = " + mult);
            div = n1 / n2;
            Console.WriteLine(n1 + " / " + n2 + " = " + div);
            mod = n1 % n2;
            Console.WriteLine(n1 + " % " + n2 + " = " + mod);

            Console.WriteLine("\nejercicio 2: operaciones booleanas");
            // mostras los signos de >, < o ==
            
            if (n1 > n2) {
                mayor = true;
            }
            else if (n1 == n2){
                igual = true;
            }
            else{
                menor = true;  
            }
            Console.WriteLine(n1 + " es mayor que " + n2 + " "+ mayor);
            Console.WriteLine(n1 + " es igual que " + n2 + " "+ igual);
            Console.WriteLine(n1 + " es menor que " + n2 + " " + menor);

            Console.WriteLine("\nejercicio 3: jerarquía de operaciones ");
            Console.WriteLine("ingrese número");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese número");
            n4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese número");
            n5 = Convert.ToDouble(Console.ReadLine());  // se añaden 3 nuevas variables para la jerarquía de operaciones

            i = n3 * n4 + n5;
            Console.WriteLine(n3 + " * "+ n4 + " + "+ n5 +" = "+ i);

            ii = n3 * (n4 + n5);
            Console.WriteLine(n3 +" * "+ " ("+ n4 + " + "+ n5 + ") "+" = "+ ii);

            iii = n3 / (n4 * n5);
            Console.WriteLine(n3+" / "+ n4 +" * "+ n5+ " = "+iii);

            iv = ((3 * n3) + (2 * n4)) / n5*n5;
            Console.WriteLine("3"+"("+n3+")"+" + "+"2"+"("+n4+")"+" / "+n5 +"^2 "+ " = "+ iii);
            Console.ReadKey();  


        }

    }
}
