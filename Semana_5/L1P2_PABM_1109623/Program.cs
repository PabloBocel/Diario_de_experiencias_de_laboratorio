namespace L1P2_PABM_1109623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");
            string nombre = "";
            double edad = 0;
            string carrera = "";
            string carné;


            Console.WriteLine("Ingresa tus datos");
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu carrera");
            carrera = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            edad = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Ingresa tu carné");
            carné = Console.ReadLine();
            // que bendición 
            Console.WriteLine("Mi segundo programa");
            Console.WriteLine("Hola " + nombre + "\ntu carrera es "+ carrera + "\ntu edad es "+ edad + "\ntu carné es "+ carné);

            Console.WriteLine("Soy " + nombre + ", tengo " + edad + " años y estudio la carrera de " + carrera + " mi número de carné es " + carné);
            Console.ReadKey();

        }
    }
}