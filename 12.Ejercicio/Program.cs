namespace _12.Ejercicio
{
    class Program
    {
        static void Main()
        {
            int suma = 0;

            for (int i = 1; i <= 99; i += 2) // Recorremos solo los impares
            {
                suma += i;
            }

            Console.WriteLine($"La suma de los números impares hasta 99 es: {suma}");
        }
    }
}