namespace _4.CondicionalDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                //verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //Falsa
                Console.WriteLine($"La persona {nombre}, no abona impuestos");
            }
            

        }       

        
    }
}
