using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace L10_PABM_1109623
{
    public class Circulo
    {
        private double radio;

        public Circulo()
        {
            radio = 0;
        }
        static void ObtenerPerimetro(ref double perimetro, double radio)
        {
            perimetro = 2 * Math.PI * radio;
        }
        static void ObtenerArea(ref double area, double radio)
        {
            area = Math.PI * Math.Pow(radio, 2);
        }
        static void ObtenerVolumen(ref double volumen, double radio)
        {
            volumen = (4 * Math.PI * Math.Pow(radio, 3)) / 3;
        }
        public void CalcularGeometria(ref double perimetro, ref double area, ref double volumen)
        {
            ObtenerPerimetro(ref perimetro, radio);
            ObtenerArea(ref area, radio);
            ObtenerVolumen(ref volumen, radio); 
        }

        static void Main(string[] args)
        {
            Circulo objCirculo = new Circulo();
            Console.WriteLine("Ingrese el radio");
            objCirculo.radio = Convert.ToInt32(Console.ReadLine());
            double perimetro = 0;
            double area = 0;
            double volumen = 0;
            objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);
            Console.WriteLine($"El perímetro del círculo es: {perimetro}");
            Console.WriteLine($"El área del círculo es: {area}");
            Console.WriteLine($"El volumen del círculo es: {volumen}");



            Console.ReadKey();
        }
    }
}
