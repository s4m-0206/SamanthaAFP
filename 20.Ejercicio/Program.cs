namespace _20.Ejercicio
{
    class Program
    {
        static void Main()
        {
            int ganados = 0, perdidos = 0, empatados = 0;
            const int totalPartidos = 30;

            Console.WriteLine("Registro de resultados de 30 partidos de fútbol\n");
            Console.WriteLine("Ingrese el resultado de cada partido:");
            Console.WriteLine("G = Ganado, P = Perdido, E = Empatado\n");

            for (int i = 1; i <= totalPartidos; i++)
            {
                string resultado;
                do
                {
                    Console.Write($"Partido {i}: ");
                    resultado = Console.ReadLine().ToUpper();

                    if (resultado == "G")
                        ganados++;
                    else if (resultado == "P")
                        perdidos++;
                    else if (resultado == "E")
                        empatados++;
                    else
                        Console.WriteLine("Entrada no válida. Ingrese G, P o E.");

                } while (resultado != "G" && resultado != "P" && resultado != "E");
            }

            // Calcular porcentajes
            double porcentajeGanados = (ganados * 100.0) / totalPartidos;
            double porcentajePerdidos = (perdidos * 100.0) / totalPartidos;
            double porcentajeEmpatados = (empatados * 100.0) / totalPartidos;

            // Mostrar resultados
            Console.WriteLine("\n--- Resultados Finales ---");
            Console.WriteLine($"Partidos ganados: {ganados} ({porcentajeGanados}%)");
            Console.WriteLine($"Partidos perdidos: {perdidos} ({porcentajePerdidos}%)");
            Console.WriteLine($"Partidos empatados: {empatados} ({porcentajeEmpatados}%)");
        }
    }
}
