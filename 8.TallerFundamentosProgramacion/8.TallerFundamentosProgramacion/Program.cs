using System.Diagnostics.CodeAnalysis;

namespace _8.TallerFundamentosProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;
            int menor = 0;
            int medio = 0;



            Console.WriteLine("ingrese numero1");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero2");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero3");
            num3 = Int32.Parse(Console.ReadLine());
            mayor = num1 > num2
               ? (num1 > num3 ? num1 : num3)
               : (num2 > num3 ? num2 : num3);
            

            Console.WriteLine($"El numero mayor es: {mayor}");
            

            if (num1 == num2 || num2 == num3 || num1 == num3)
            {
                Console.WriteLine("Error: Debe ingresar nuevo numero");

            }
;
            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
                if (num2 < num3)
                {
                    medio = num2;
                    mayor = num3;

                }
                else
                {
                    medio = num3;
                    mayor = num2;

                }


            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
                if (num1 < num3)
                {
                    medio = num1;
                    mayor = num3;

                }
                else
                {
                    medio = num3;
                    mayor = num1;

                }


            }
            else if (num3 < num2 && num3 < num1)
            {
                menor = num3;
                if (num3 < num1)
                {
                    medio = num1;
                    mayor = num2;

                }
                else
                {
                    medio = num2;
                    mayor = num1;

                }

                


            }
            Console.WriteLine("Ordenados:" + menor + "-" + medio + "-" + mayor + "-");



        }
    }
}
