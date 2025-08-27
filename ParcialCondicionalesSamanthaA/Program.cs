namespace ParcialCondicionalesSamanthaA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo = "";
            string ingrediente1 = "", ingrediente2 = "", ingrediente3 = "";
            int precio = 0;
            double iva = 0;
            double valoriva = 0;
            double preciofinal = 0;
            

            Console.WriteLine("Que tipo de pizza desea comprar?  1.Vegetariana, 2. No Vegetariana");
            Console.WriteLine("Opcion");
            int opcion = int.Parse(Console.ReadLine());





            if (opcion == 1)
            {
                tipo = "Vegetariana";
                Console.WriteLine("Ingredientes disponibles: Pimiento, Tofu, Champiñones, Tomate, Lechuga");
                Console.WriteLine("Ingrediente 1:");
                ingrediente1 = Console.ReadLine();
                Console.WriteLine("Ingrediente 2:");
                ingrediente2 = Console.ReadLine();
                Console.WriteLine("Ingrediente 3:");
                ingrediente3 = Console.ReadLine();

                string combo = ingrediente1 + "," + ingrediente2 + "," + ingrediente3;

                //Disyuncion:
                bool esCombo1 =
                    (ingrediente1 == "Pimiento" || ingrediente2 == "Pimiento" || ingrediente3 == "Pimiento") &&
                    (ingrediente2 == "Champiñones" || ingrediente2 == "Champiñones" || ingrediente3 == "Champiñones") &&
                    (ingrediente3 == "Lechuga" || ingrediente2 == "Lechuga" || ingrediente3 == "Lechuga");

                bool esCombo2 =
                    (ingrediente1 == "Tofu" || ingrediente1 == "Tofu" || ingrediente1 == "Tofu") &&
                    (ingrediente2 == "Champiñones" || ingrediente2 == "Champiñones" || ingrediente2 == "Champiñones") &&
                    (ingrediente3 == "Lechuga" || ingrediente3 == "Lechuga" || ingrediente3 == "Lechuga");

                if (esCombo1)
                {
                    precio = 20000;
                    iva = 0.19;
                }
                else if (esCombo2)
                {
                    precio = 30000;
                    iva = 0.15;
                }
                else
                {
                    precio = 25000;
                    iva = 0.10;
                }

            }
            else if (opcion == 2)
            {
                tipo = "No Vegetariana";
                Console.WriteLine("Ingredientes disponibles: Res, Chorizo, Pollo, Tocineta, Cerdo");

                Console.WriteLine("Ingrediente 1:");
                ingrediente1 = Console.ReadLine();
                Console.WriteLine("Ingrediente 2:");
                ingrediente2 = Console.ReadLine();
                Console.WriteLine("Ingrediente 3:");
                ingrediente3 = Console.ReadLine();


                bool combo1 = (ingrediente1 == "Res" && ingrediente2 == "Pollo") || (ingrediente1 == "Pollo" && ingrediente2 == "Res");
                bool combo2 = (ingrediente1 == "Res" && ingrediente2 == "Tocineta") || (ingrediente1 == "Tocineta" && ingrediente2 == "Res");
                bool combo3 = (ingrediente1 == "Chorizo" && ingrediente2 == "Tocineta") || (ingrediente1 == "Tocineta" && ingrediente2 == "Chorizo");

                if (combo1)
                {
                    precio = 10000;
                    iva = 0.19;
                }
                else if (combo2)
                {
                    precio = 15000;
                    iva = 0.17;

                }
                else if (combo3)
                {
                    precio = 25000;
                    iva = 0.09;

                }
                else
                {
                    precio = 22000;
                    iva = 0.10;
                }
            }
            else
            {
                Console.WriteLine("Opcion invalida");
                return;
            }

            //Precio Final
            valoriva = precio * iva;
            preciofinal = precio + valoriva;

            Console.WriteLine("Resumen del pedido:");

            Console.WriteLine("Tipo de pizza: " + tipo);

            if (tipo == "Vegetariana")
            {
                Console.WriteLine("Ingredientes: " + ingrediente1 + ", " + ingrediente2 + ", " + ingrediente3);
            }
            else
            {
                Console.WriteLine("Ingredientes: " + ingrediente1 + ", " + ingrediente2);
            }

            Console.WriteLine("Precio base: $" + precio);
            Console.WriteLine("IVA aplicado (" + (iva * 100) + "%): $" + valoriva);
            Console.WriteLine("Precio final: $" + preciofinal);

        }
    }
}



