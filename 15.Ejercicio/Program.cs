namespace _15.Ejercicio
{
    class Program
    {
        static void Main()
        {
            double ahorroMensual, ahorroTotal = 0;

            Console.WriteLine("Cálculo del ahorro anual con depósitos mensuales variables.\n");

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.Write($"Ingrese el ahorro del mes {mes}: ");
                ahorroMensual = double.Parse(Console.ReadLine());

                ahorroTotal += ahorroMensual;

                Console.WriteLine($"Ahorro acumulado hasta el mes {mes}: {ahorroTotal}\n");
            }

            Console.WriteLine($"El ahorro total al finalizar el año es: {ahorroTotal}");
        }
    }
}
