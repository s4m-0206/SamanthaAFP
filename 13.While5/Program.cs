namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuantos numeros pares hay en un rango de numeros del 1 al numero n//
            int contador = 1;
            int cantidadPares = 0;
            int rango = 0;

            Console.WriteLine("Ingre el rango de numeros a evaluar:");
            rango = int.Parse(Console.ReadLine());

            while (contador <= rango)
            {
                if(contador %2==0)
                {
                    cantidadPares++;
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de numeros pares del 1 hasta {rango}, es: {cantidadPares}");
        }
    }
}
