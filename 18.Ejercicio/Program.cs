namespace _18.Ejercicio
{
    class Program
    {
        static void Main()
        {
            int cantidadUsuarios = 0;
            double sumaSaldos = 0;
            string continuar;

            Console.WriteLine("Sistema de evaluación de crédito\n");

            do
            {
                // Pedir datos del usuario
                Console.Write("Ingrese el nombre del usuario: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el número de cuenta: ");
                string numeroCuenta = Console.ReadLine();

                Console.Write("Ingrese el saldo: ");
                double saldo = double.Parse(Console.ReadLine());

                // Acumular datos para estadísticas
                cantidadUsuarios++;
                sumaSaldos += saldo;

                // Evaluar si es apto para crédito
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"\nNombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numeroCuenta}");
                    Console.WriteLine($"Saldo: {saldo}");
                    Console.WriteLine("Resultado: Es apto para el crédito\n");
                }
                else
                {
                    Console.WriteLine($"\nNombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numeroCuenta}");
                    Console.WriteLine($"Saldo: {saldo}");
                    Console.WriteLine("Resultado: No es apto para el crédito\n");
                }

                // Preguntar si se desea continuar
                Console.Write("¿Desea ingresar otro usuario? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            // Mostrar resumen
            if (cantidadUsuarios > 0)
            {
                double promedio = sumaSaldos / cantidadUsuarios;
                Console.WriteLine($"\nCantidad de usuarios consultados: {cantidadUsuarios}");
                Console.WriteLine($"Promedio de los saldos: {promedio}");
            }
            else
            {
                Console.WriteLine("\nNo se ingresaron usuarios.");
            }
        }
    }
}
