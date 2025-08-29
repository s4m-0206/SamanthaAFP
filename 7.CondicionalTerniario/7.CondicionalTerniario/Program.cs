namespace _7.CondicionalTerniario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            Console.WriteLine("ingrese edad");
            edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine(edad >= 18 ? "es mayor de edad" : "no es mayor de edad");

            /*Algoritmo que perimita ingresar 3 numeros enteros diferentes,
            y muestre mensaje diciendo cual es el mayor*/

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;

            Console.WriteLine("ingrese el numero 1");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 3");
            num3 = Int32.Parse(Console.ReadLine());
            mayor = num1 > num2
                ? (num1 > num3 ? num1 : num3)
                : (num2 > num3 ? num2 : num3);
            Console.WriteLine($"El numero mayor es: {mayor}");




        }
    }
}
