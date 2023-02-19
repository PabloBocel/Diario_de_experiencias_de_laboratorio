namespace L1_PABM_1109623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Hola clase");
            Console.WriteLine("Soy Pablo");

            Console.WriteLine("\nIngresa tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola mundo");
            if (nombre == ""){ 
                Console.WriteLine("Nombre no valido");
            }else
            {
            Console.WriteLine("Hola "+ nombre +" Como estas?");
            }
            Console.ReadKey(); 

        }
    }
}