namespace _29.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
        }

        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }

        static int[,] LlenarMatriz(int[,] matriz)
        {
            return matriz;
        }
    }
}