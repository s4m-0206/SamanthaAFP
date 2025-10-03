namespace _27.Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            // Contadores
            int positivos = 0, negativos = 0, ceros = 0;

            Console.WriteLine("\nIngrese los elementos de la matriz:");

            // Llenar la matriz y contar
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Matriz[{i},{j}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());

                    if (matriz[i, j] > 0)
                        positivos++;
                    else if (matriz[i, j] < 0)
                        negativos++;
                    else
                        ceros++;
                }
            }

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);
        }
    }
}
