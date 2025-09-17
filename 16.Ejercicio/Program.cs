namespace _16.Ejercicio
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); // Número aleatorio entre 1 y 100
            int intento = 0;

            Console.WriteLine("He pensado un número entre 1 y 100.");
            Console.WriteLine("¡Intenta adivinarlo!");

            while (intento != numeroSecreto)
            {
                Console.Write("Tu intento: ");

                // Validamos que el usuario ingrese un número válido
                if (!int.TryParse(Console.ReadLine(), out intento))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue;
                }

                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine($"¡Correcto! El número era {numeroSecreto}.");
                }
            }
        }
    }
}

