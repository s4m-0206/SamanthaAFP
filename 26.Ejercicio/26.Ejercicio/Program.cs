namespace _26.Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = 2, columnas = 3;
                int[,] matriz1 = new int[filas, columnas];
                int[,] matriz2 = new int[filas, columnas];
                int[,] suma = new int[filas, columnas];

                Console.WriteLine("Ingrese los elementos de la primera matriz (2x3):");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write($"Matriz1[{i},{j}]: ");
                        matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nIngrese los elementos de la segunda matriz (2x3):");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write($"Matriz2[{i},{j}]: ");
                        matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Calcular la suma de las matrices
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        suma[i, j] = matriz1[i, j] + matriz2[i, j];
                    }
                }

                // Mostrar matriz resultante
                Console.WriteLine("\nLa matriz suma es:");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(suma[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
