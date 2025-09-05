namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un numero dado por el usuario(5! = 1*2*3*4*5)
            int num = 0;
            int contador = 1;
            int acumulador = 0;
            Console.WriteLine("Ingrese un numero para calcular su factorial");
            num = int.Parse(Console.ReadLine());

            while (contador<=num)
            {
                acumulador = acumulador * contador;
                Console.WriteLine($"Contador: {contador} - Factorial: {acumulador}");
                contador++;
            }
            Console.WriteLine($"El factorial es numero {num}, es: {acumulador}");
        }
    }
}
