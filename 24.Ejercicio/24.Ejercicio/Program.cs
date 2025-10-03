namespace _24.Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10];
            double suma = 0;

            // Leer los 10 números
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                suma += numeros[i];
            }

            // Calcular el promedio
            double promedio = suma / numeros.Length;

            // Mostrar el promedio
            Console.WriteLine("\nEl promedio de los números ingresados es: " + promedio);
        }
    }
}
