namespace IntentoSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Maxhabitaciones = 20;
            int Maxhuespedes = 20;
            int Maxreservas = 5;

            int totalHabitaciones = 0;
            int totalHuespedes = 0;

            int[] numHabitacion = new int[Maxhabitaciones];
            string[] tipoHabitacion = new string[Maxhabitaciones];
            double[] precioHabitacion = new double[Maxhabitaciones];
            bool[] disponibleHabitacion = new bool[Maxhabitaciones];

            string[] nombreHuesped = new string[Maxhuespedes];
            string[] documentoHuesped = new string[Maxhuespedes];
            string[] telefonoHuesped = new string[Maxhuespedes];

            // Arreglos de reservas
            string[,] reservas = new string[Maxhabitaciones, Maxreservas];
            int[,] noches = new int[Maxhabitaciones, Maxreservas];
            string[,] fechaEntrada = new string[Maxhabitaciones, Maxreservas];

            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("\nMENÚ PRINCIPAL");
                Console.WriteLine("1. Gestión de habitaciones");
                Console.WriteLine("2. Gestión de huéspedes");
                Console.WriteLine("3. Gestión de reservas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    GestionHabitaciones(numHabitacion, tipoHabitacion, precioHabitacion, disponibleHabitacion, ref totalHabitaciones, Maxhabitaciones);
                }
                //else if (opcion == 2)
                {
                    //GestionHuespedes(nombreHuesped, documentoHuesped, telefonoHuesped, ref totalHuespedes, Maxhuespedes);
                }
                //else if (opcion == 3)
                {
                    //GestionReservas(numHabitacion, disponibleHabitacion, nombreHuesped, reservas, fechaEntrada, noches, totalHabitaciones, totalHuespedes, Maxreservas);
                }
            }
        }


        //Ensayo con gestionhab
        static void GestionHabitaciones(int[] numHab, string[] tipo, double[] precio, bool[] disp, ref int total, int max)
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.WriteLine("\nGESTIÓN DE HABITACIONES:");
                Console.WriteLine("1. Registrar nueva habitación");
                Console.WriteLine("2. Ver lista de habitaciones");
                Console.WriteLine("3. Editar habitación");
                Console.WriteLine("4. Ver disponibilidad");
                Console.WriteLine("5. Volver");
                Console.Write("Seleccione: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    if (total < max)
                    {
                        Console.Write("Número de habitación: ");
                        numHab[total] = int.Parse(Console.ReadLine());
                        Console.Write("Tipo (Sencilla/Doble/Suite): ");
                        tipo[total] = Console.ReadLine();

                        // Asigna el precio automáticamente según el tipo
                        if (tipo[total].ToLower() == "sencilla")
                            precio[total] = 100000;
                        else if (tipo[total].ToLower() == "doble")
                            precio[total] = 180000;
                        else if (tipo[total].ToLower() == "suite")
                            precio[total] = 300000;
                        else
                            precio[total] = 120000; // valor por defecto

                        disp[total] = true;
                        total++;
                        Console.WriteLine("Habitación registrada con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("No se pueden registrar más habitaciones.");
                    }
                }
                else if (opcion == 2)
                {
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine($"Número: {numHab[i]}, Tipo: {tipo[i]}, Precio/noche: {precio[i]}, Disponible: {disp[i]}");
                    }
                }
            }
        }
        //Ensayo gestionhuespedes
        static void GestionHuespedes(string[] nombre, string[] documento, string[] telefono, ref int total, int max)
        {
            int opcion = 0;
            while (opcion != 3)
            {
                Console.WriteLine("\n--- GESTIÓN DE HUÉSPEDES ---");
                Console.WriteLine("1. Registrar huésped");
                Console.WriteLine("2. Ver lista de huéspedes");
                Console.WriteLine("3. Volver");
                Console.Write("Seleccione: ");
                opcion = int.Parse(Console.ReadLine());
            }
        }
    }
}