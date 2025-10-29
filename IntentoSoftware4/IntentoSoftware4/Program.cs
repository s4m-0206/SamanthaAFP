namespace IntentoSoftware4
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
            string[,] fechaEntrada = new string[Maxhabitaciones, Maxreservas];
            int[,] noches = new int[Maxhabitaciones, Maxreservas];

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
                    GestionReservas(numHabitacion, tipoHabitacion, precioHabitacion, disponibleHabitacion, nombreHuesped, reservas, fechaEntrada, noches, totalHabitaciones, totalHuespedes, Maxreservas);
                }
            }
        }

        // ==============================================
        // GESTIÓN DE HABITACIONES
        // ==============================================
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

                        if (tipo[total].ToLower() == "sencilla")
                            precio[total] = 100000;
                        else if (tipo[total].ToLower() == "doble")
                            precio[total] = 180000;
                        else if (tipo[total].ToLower() == "suite")
                            precio[total] = 300000;
                        else
                            precio[total] = 120000;

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
                    Console.WriteLine("\nLISTA DE HABITACIONES:");
                    for (int i = 0; i < total; i++)
                        Console.WriteLine($"N° {numHab[i]} | {tipo[i]} | ${precio[i]} | Disponible: {disp[i]}");
                }
                else if (opcion == 3)
                {
                    Console.Write("Ingrese el número de habitación a editar: ");
                    int buscar = int.Parse(Console.ReadLine() ?? "0");
                    bool encontrado = false;

                    for (int i = 0; i < total; i++)
                    {
                        if (numHab[i] == buscar)
                        {
                            encontrado = true;
                            Console.Write("Nuevo tipo: ");
                            tipo[i] = Console.ReadLine();
                            Console.Write("Nuevo precio por noche: ");
                            precio[i] = double.Parse(Console.ReadLine() ?? "0");
                            Console.Write("¿Está disponible? (true/false): ");
                            disp[i] = bool.Parse(Console.ReadLine() ?? "true");
                            Console.WriteLine("Habitación actualizada.");
                        }
                    }
                    if (!encontrado)
                        Console.WriteLine("Habitación no encontrada.");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\nHABITACIONES DISPONIBLES:");
                    for (int i = 0; i < total; i++)
                    {
                        if (disp[i])
                            Console.WriteLine($"N° {numHab[i]} - {tipo[i]} - ${precio[i]}");
                    }
                }
            }
        }

        // ==============================================
        // GESTIÓN DE HUÉSPEDES
        // ==============================================
        static void GestionHuespedes(string[] nombre, string[] documento, string[] telefono, ref int total, int max)
        {
            int opcion = 0;
            while (opcion != 4)
            {
                Console.WriteLine("\n--- GESTIÓN DE HUÉSPEDES ---");
                Console.WriteLine("1. Registrar huésped");
                Console.WriteLine("2. Ver lista de huéspedes");
                Console.WriteLine("3. Editar huésped");
                Console.WriteLine("4. Volver");
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
                    else Console.WriteLine("Límite alcanzado.");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("\nLISTA DE HUÉSPEDES:");
                    for (int i = 0; i < total; i++)
                        Console.WriteLine($"{nombre[i]} | Doc: {documento[i]} | Tel: {telefono[i]}");
                }
                else if (opcion == 3)
                {
                    Console.Write("Ingrese documento del huésped a editar: ");
                    string doc = Console.ReadLine();
                    bool encontrado = false;

                    for (int i = 0; i < total; i++)
                    {
                        if (documento[i] == doc)
                        {
                            encontrado = true;
                            Console.Write("Nuevo nombre: ");
                            nombre[i] = Console.ReadLine();
                            Console.Write("Nuevo teléfono: ");
                            telefono[i] = Console.ReadLine();
                            Console.WriteLine("Huésped actualizado.");
                        }
                    }
                    if (!encontrado)
                        Console.WriteLine("No se encontró el huésped.");
                }
            }
        }

        // ==============================================
        // GESTIÓN DE RESERVAS
        // ==============================================
        static void GestionReservas(int[] numHab, string[] tipo, double[] precio, bool[] disp, string[] huespedes, string[,] reservas, string[,] fechas, int[,] noches, int totalHab, int totalHuesped, int maxRes)
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.WriteLine("\n--- GESTIÓN DE RESERVAS ---");
                Console.WriteLine("1. Crear reserva");
                Console.WriteLine("2. Ver reservas por habitación");
                Console.WriteLine("3. Ver historial por huésped");
                Console.WriteLine("4. Cancelar reserva");
                Console.WriteLine("5. Volver");
                Console.Write("Seleccione: ");
                opcion = int.Parse(Console.ReadLine() ?? "0");

                if (opcion == 1)
                {
                    Console.Write("Número de habitación: ");
                    int num = int.Parse(Console.ReadLine() ?? "0");
                    int posHab = -1;
                    for (int i = 0; i < totalHab; i++)
                        if (numHab[i] == num) posHab = i;

                    if (posHab == -1)
                    {
                        Console.WriteLine("Habitación no encontrada.");
                        continue;
                    }

                    if (!disp[posHab])
                    {
                        Console.WriteLine("Habitación ocupada.");
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
                        Console.Write("Número de noches: ");
                        noches[posHab, posRes] = int.Parse(Console.ReadLine() ?? "0");

                        double totalPagar = precio[posHab] * noches[posHab, posRes];
                        Console.WriteLine($"\nReserva creada correctamente.\nTotal a pagar: ${totalPagar}");
                        disp[posHab] = false;
                    }
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese número de habitación: ");
                    int num = int.Parse(Console.ReadLine() ?? "0");
                    int posHab = -1;
                    for (int i = 0; i < totalHab; i++)
                        if (numHab[i] == num) posHab = i;

                    if (posHab == -1)
                        Console.WriteLine("Habitación no encontrada.");
                    else
                    {
                        Console.WriteLine($"\nReservas de la habitación {num}:");
                        for (int r = 0; r < maxRes; r++)
                        {
                            if (reservas[posHab, r] != null)
                                Console.WriteLine($"Huésped: {reservas[posHab, r]} | Fecha: {fechas[posHab, r]} | Noches: {noches[posHab, r]}");
                        }
                    }
                }
                else if (opcion == 3)
                {
                    Console.Write("Ingrese nombre del huésped: ");
                    string nom = Console.ReadLine();
                    bool encontrado = false;

                    for (int i = 0; i < totalHab; i++)
                    {
                        for (int r = 0; r < maxRes; r++)
                        {
                            if (reservas[i, r] == nom)
                            {
                                encontrado = true;
                                Console.WriteLine($"Hab. {numHab[i]} ({tipo[i]}), Entrada: {fechas[i, r]}, Noches: {noches[i, r]}");
                            }
                        }
                    }

                    if (!encontrado)
                        Console.WriteLine("No se encontraron reservas para ese huésped.");
                }
                else if (opcion == 4)
                {
                    Console.Write("Ingrese número de habitación: ");
                    int num = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Ingrese nombre del huésped: ");
                    string nom = Console.ReadLine();

                    bool cancelada = false;
                    for (int i = 0; i < totalHab; i++)
                    {
                        if (numHab[i] == num)
                        {
                            for (int r = 0; r < maxRes; r++)
                            {
                                if (reservas[i, r] == nom)
                                {
                                    reservas[i, r] = null;
                                    fechas[i, r] = null;
                                    noches[i, r] = 0;
                                    disp[i] = true;
                                    cancelada = true;
                                    Console.WriteLine("Reserva cancelada correctamente.");
                                }
                            }
                        }
                    }
                    if (!cancelada)
                        Console.WriteLine("Reserva no encontrada.");
                }
            }
        }
    }
}
