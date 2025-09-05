namespace _17DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que genera y suma los primeros 5 numeros enteros

            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador = acumulador + contador;
            } while (contador < 5);

            Console.WriteLine("La suma de los cinco primeros numeros enteros es:"+acumulador);*/

            //17.Algoritmo que solicita un numero y genere si correspondiente tabla de multiplicar desde el 1 hasta el 10. Y asi sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar

            int contador = 1;
            int numero = 0;
            string respuesta = "";

            Console.Write("Ingrese un numero para calcular su tabla de multiplicar");
            numero=int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                contador++;
            } while (contador <= 10);
            Console.WriteLine("Desea generar una nueva tabla de multiplicar? s:si, n:no");
            respuesta = Console.ReadLine().ToLower();
        }
    }
}
