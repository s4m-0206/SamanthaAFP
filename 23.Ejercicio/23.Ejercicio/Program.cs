namespace _23.Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];

            // Asignar el valor 10 a cada posición
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
            }

            // Leer y mostrar cada elemento
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("numeros[" + i + "] = " + numeros[i]);
            }
        }
    }
}
