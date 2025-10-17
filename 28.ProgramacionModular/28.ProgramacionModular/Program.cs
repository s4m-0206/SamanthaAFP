namespace _28.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensaje("Soy Ferney");
            MostrarMensaje($"Tengo {CalcularEdad()} años");
            MostrarMensaje($"Tengo {CalcularEdad(2025, 1999)}");
        }

        //Módulo 1 - Procedimiento sin parámetros
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la Programación Modular");
            MostrarMensaje("Estoy siendo llamado desde MostarMensaje()");
        }

        //Módulo 2 - Procedimiento con parámetros 
        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Función sin parámetros

        static int CalcularEdad()
        {
            int edad = 2025 - 1981;
            return edad;
        }

        //Módulo 4 - Funcíon con parámetros
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}