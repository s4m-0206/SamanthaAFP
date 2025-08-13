namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1 Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona,
                 si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla 
                 con el nombre de la persona,
                 indicando que debe abonar impuestos.*/

            //condicional simple
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el Nombre");
            nombre = Console.ReadLine();//todo lo que yo leo desde la consola llega como un string 


            Console.WriteLine(" Ingrese sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine($"la persona {nombre}, debe abonar impuestos");
            }

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18,
             * se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”.*/



        }
    }
}
