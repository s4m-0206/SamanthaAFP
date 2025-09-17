namespace _21.Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for (int i = 1; i <= 5; i++)
            {
                acumulador += i;
            }

            Console.WriteLine($"La suma de los cinco primeros números enteros es {acumulador}");
        }
    }
}