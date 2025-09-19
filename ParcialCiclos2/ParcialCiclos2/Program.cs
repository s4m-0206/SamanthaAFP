namespace ParcialCiclos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalEstudiantes = 14;
            int numeroEstudiante = 1;

            double nota;
            double suma = 0;
            double mayor = 0;
            double menor = 10;
            int aprobados = 0;

            while (numeroEstudiante <= totalEstudiantes)
            {
                Console.Write("Ingrese la nota del estudiante " + numeroEstudiante + " (del 0 al 10): ");
                nota = Convert.ToDouble(Console.ReadLine());

                //suma
                suma = suma + nota;

                //nota mayor
                if (nota > mayor)
                {
                    mayor = nota;
                }

                //nota menor
                if (nota < menor)
                {
                    menor = nota;
                }

                //aprobados
                if (nota >= 6)
                {
                    aprobados = aprobados + 1;
                }

                numeroEstudiante = numeroEstudiante + 1; 
            }

            double promedio = suma / totalEstudiantes;

            Console.WriteLine("Resultados del curso:");
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Nota mas alta: " + mayor);
            Console.WriteLine("Nota mas baja: " + menor);
            Console.WriteLine("Cantidad de aprobados: " + aprobados);
        }
    }
}

