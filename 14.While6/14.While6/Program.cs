namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosazar = 0;
            int cantidadnumeros = 0;
            int contador = 0;
            int mayorcero = 0;
            int menorcero = 0;
            int igualcero = 0;

            Console.WriteLine("cuantos numeros quiere ingresar");
            cantidadnumeros = int.Parse(Console.ReadLine());

            while (contador <= cantidadnumeros)
            {
                Console.WriteLine($"numeros al azar #{contador + 1}");
                numerosazar = int.Parse(Console.ReadLine());

                if (numerosazar > 0)
                {
                    mayorcero++;
                }
                else if (numerosazar < 0)
                {
                    menorcero++;

                }
                if (numerosazar == 0)
                {
                    igualcero++;
                }
                contador++;

            }
            Console.WriteLine($"numeros mayores {mayorcero}");
            Console.WriteLine($"numeros menor {menorcero}");
            Console.WriteLine($"numeros igual {igualcero}");

        }
    }
}