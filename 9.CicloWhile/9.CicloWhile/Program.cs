namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita generar primeros 5 numeros enteros positivos y realizar y mostrar su suma.

            int contador = 0;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador; //acumulador =acumulador+contador
                contador++;
            }
            
            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");
        }
    }
}
+