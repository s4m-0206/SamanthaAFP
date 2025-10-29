namespace IntentoSoftware3
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

            string[,] reservas = new string[Maxhabitaciones, Maxreservas];
            int[,] noches = new int[Maxhabitaciones, Maxreservas];
            string[,] fechaEntrada = new string[Maxhabitaciones, Maxreservas];

            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Gestión de habitaciones");
                Console.WriteLine("2. Gestión de huéspedes");
                Console.WriteLine("3. Gestión de reservas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine() ?? "0");

                if (opcion == 1)
                {
                    GestionHabitaciones(numHabitacion, tipoHabitacion, precioHabitacion, disponibleHabitacion, ref totalHabitaciones, Maxhabitaciones);
                }
                else if (opcion == 2)
                {
                    GestionHuespedes(nombreHuesped, documentoHuesped, telefonoHuesped, ref totalHuespedes, Maxhuespedes);
                }
                else if (opcion == 3)
                {
                    // 🔧 Aquí estaba el error — ahora la llamada está completa
                    GestionReservas(numHabitacion, tipoHabitacion, precioHabitacion, disponibleHabitacion, nombreHuesped, reservas, fechaEntrada, noches, totalHabitaciones, totalHuespedes, Maxreservas);
                }
            }
        }

        // ========== GESTIÓN DE HABITACIONES ==========
        static void GestionHabitaciones(int[] numHab, string[] tipo, double[] precio, bool[] disp, ref int total, int max)
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.WriteLine("\n--- GESTIÓN DE HABITACIONES ---");
                Console.WriteLine("1. Registrar nueva habitación");
                Console.WriteLine("2. Ver lista de habitaciones");
                Console.WriteLine("3. Editar habitación");
                Console.WriteLine("4. Ver disponibilidad");
                Console.WriteLine("5. Volver");
                Console.Write("Seleccione: ");
                opcion = int.Parse(Console.ReadLine() ?? "0");

                if (opcion == 1)
                {
                    if (total < max)
                    {
                        Console.Write("Número de habitación: ");
                        numHab[total] = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Tipo (Sencilla/Doble/Suite): ");
                        tipo[total] = Console.ReadLine();

                        // Asignación automática de precios
                        if (tipo[total].ToLower() == "sencilla")
                            precio[total] = 100000;
                        else if (tipo[total].ToLower() == "doble")
                            precio[total] = 180000;
                        else if (tipo[total].ToLower() == "suite")
                            precio[total] = 300000;
                        else
                            precio[total] = 120000; // por defecto

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
                    Console.WriteLine("\nLISTA DE HABITACIONES REGISTRADAS:");
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine($"Número: {numHab[i]}, Tipo: {tipo[i]}, Precio/noche: {precio[i]}, Disponible: {disp[i]}");
                    }
                }
            }
        }

        // ========== GESTIÓN DE HUÉSPEDES ==========
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
                opcion = int.Parse(Console.ReadLine() ?? "0");

                if (opcion == 1)
                {
                    if (total < max)
                    {
                        Console.Write("Nombre: ");
                        nombre[total] = Console.ReadLine();
                        Console.Write("Documento: ");
                        documento[total] = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        telefono[total] = Console.ReadLine();
                        total++;
                        Console.WriteLine("Huésped registrado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("No se pueden registrar más huéspedes.");
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("\nLISTA DE HUÉSPEDES REGISTRADOS:");
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine($"Nombre: {nombre[i]}, Documento: {documento[i]}, Teléfono: {telefono[i]}");
                    }
                }
            }
        }

        // ========== GESTIÓN DE RESERVAS ==========
        static void GestionReservas(int[] numHab, string[] tipo, double[] precio, bool[] disp, string[] nombre, string[,] reservas, string[,] fechas, int[,] noches, int totalHab, int totalHuesped, int maxRes)
        {
            int opcion = 0;
            while (opcion != 3)
            {
                Console.WriteLine("\n--- GESTIÓN DE RESERVAS ---");
                Console.WriteLine("1. Crear reserva");
                Console.WriteLine("2. Ver reservas");
                Console.WriteLine("3. Volver");
                Console.Write("Seleccione: ");
                opcion = int.Parse(Console.ReadLine() ?? "0");

                if (opcion == 1)
                {
                    Console.Write("Número de habitación: ");
                    int num = int.Parse(Console.ReadLine() ?? "0");
                    int posHab = -1;

                    for (int i = 0; i < totalHab; i++)
                    {
                        if (numHab[i] == num)
                            posHab = i;
                    }

                    if (posHab == -1)
                    {
                        Console.WriteLine("Habitación no encontrada.");
                        continue;
                    }

                    if (!disp[posHab])
                    {
                        Console.WriteLine("La habitación está ocupada.");
                        continue;
                    }

                    Console.Write("Nombre del huésped: ");
                    string nom = Console.ReadLine();

                    int posRes = -1;
                    for (int r = 0; r < maxRes; r++)
                    {
                        if (reservas[posHab, r] == null)
                        {
                            posRes = r;
                            break;
                        }
                    }

                    if (posRes == -1)
                    {
                        Console.WriteLine("La habitación alcanzó el máximo de reservas.");
                    }
                    else
                    {
                        reservas[posHab, posRes] = nom;
                        Console.Write("Fecha de entrada: ");
                        fechas[posHab, posRes] = Console.ReadLine();
                        Console.Write("¿Cuántas noches se quedará?: ");
                        noches[posHab, posRes] = int.Parse(Console.ReadLine() ?? "0");

                        double totalPagar = precio[posHab] * noches[posHab, posRes];

                        Console.WriteLine($"\n✅ Reserva creada con éxito.");
                        Console.WriteLine($"Tipo: {tipo[posHab]}");
                        Console.WriteLine($"Precio por noche: {precio[posHab]}");
                        Console.WriteLine($"Noches: {noches[posHab, posRes]}");
                        Console.WriteLine($"Total a pagar: {totalPagar}\n");

                        disp[posHab] = false;
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("\nLISTA DE RESERVAS REGISTRADAS:");
                    for (int i = 0; i < totalHab; i++)
                    {
                        for (int r = 0; r < maxRes; r++)
                        {
                            if (reservas[i, r] != null)
                            {
                                Console.WriteLine($"Habitación {numHab[i]} ({tipo[i]}) reservada por {reservas[i, r]} el {fechas[i, r]} por {noches[i, r]} noches.");
                            }
                        }
                    }
                }
            }
        }
    }
}
