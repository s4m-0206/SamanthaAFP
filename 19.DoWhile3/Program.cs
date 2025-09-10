namespace _19.DoWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantidadEstudiantes = 0;
            int edad = 0;
            int genero = 0;
            int CantidadHombres = 0;
            int CantidadMujeres = 0;
            int CantidadMayores = 0;
            int CantidadMenores = 0;
            int cantidad = 200;

            do
            {
                Console.WriteLine($"Estudiante {CantidadEstudiantes}: ");
                Console.WriteLine("Ingrese su edad");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su género");
                Console.WriteLine("1.Hombre   2.Mujer");
                genero = int.Parse(Console.ReadLine());

                if (genero == 1)
                {
                    CantidadHombres++;
                }
                else
                {
                    CantidadMujeres++;
                }
                if (edad >= 18)
                {
                    CantidadMayores++;
                }
                else
                {
                    CantidadMayores++;
                }
            } while (CantidadEstudiantes < 200);

            Console.WriteLine($"De los 100 estudiantes, {CantidadHombres} son hombres, {CantidadMujeres} son mujeres, {CantidadMayores} son son mayores de edad, {CantidadMenores} son menores de edad");
        }
    }
}
