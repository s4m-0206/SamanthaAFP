namespace _11.Ejercicio
{
    using System;

    class Program
    {
        static void Main()
        {
            int numero;
            int suma = 0;

            Console.WriteLine("Ingrese números enteros positivos para sumarlos.");
            Console.WriteLine("Ingrese un número negativo para finalizar.");

            do
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    suma += numero;
                }

            } while (numero >= 0);

            Console.WriteLine($"La suma de los números ingresados es: {suma}");
        }
    }
}
