namespace ParcialMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tablero = new string[8, 8];
            string[,] correcto = {
            { "T","C","A","D","R","A","C","T" },
            { "p","p","p","p","p","p","p","p" },
            { "x","x","x","x","x","x","x","x" },
            { "x","x","x","x","x","x","x","x" },
            { "x","x","x","x","x","x","x","x" },
            { "x","x","x","x","x","x","x","x" },
            { "p","p","p","p","p","p","p","p" },
            { "T","C","A","D","R","A","C","T" }
        };

            Console.WriteLine("----------TABLERO DE AJEDREZ (8x8)------------");
            Console.WriteLine("Fichas que puedes usar: R (Rey), D (Dama), T (Torre), A (Alfil), C (Caballo), p (Peón), x (Vacía)");
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    bool valido = false;
                    string ficha = "";

                    while (!valido)
                    {
                        Console.Write("Ingrese ficha para [" + i + "," + j + "]: ");
                        ficha = Console.ReadLine();

                        if (ficha == "R" || ficha == "D" || ficha == "T" || ficha == "A" || ficha == "C" || ficha == "p" || ficha == "x")
                        {
                            if (ficha == correcto[i, j])
                            {
                                valido = true;
                            }
                            else
                            {
                                Console.WriteLine("Ficha incorrecta");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ficha incorrecta");
                        }
                    }

                    tablero[i, j] = ficha;
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------------- TABLERO FINAL ----------------");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(tablero[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nCompletaste el tablero completamente ");
        }
    }
}
