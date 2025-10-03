namespace _25.Taller
{
    internal class Program
    {
            static void Main(string[] args)
            {

                /*int[] numeros = new int[15];
                Random random = new Random();


                for (int i = 0; i < numeros.Length; i++)
                {

                    numeros[i] = random.Next(1, 101);

                }


                Console.WriteLine("vector:");
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine(numeros[i] + " ");
                }
                Console.WriteLine();

                int max = numeros[0];
                int min = numeros[0];

                for (int i = 1; i < numeros.Length; i++)
                {
                    if (numeros[i] > max) max = numeros[i];
                    if (numeros[i] < min) min = numeros[i];
                }


                Console.WriteLine("maxima:" + max);
                Console.WriteLine("minimo:" + min);*/








                /*char[] letras = new char[7];

                // Pedir caracteres
                Console.WriteLine("Ingrese 7 caracteres:");
                for (int i = 0; i < letras.Length; i++)
                {
                    letras[i] = Console.ReadKey().KeyChar;
                    Console.Write(" ");
                }
                Console.WriteLine();

                // Mostrar vector original
                Console.WriteLine("Vector original:");
                for (int i = 0; i < letras.Length; i++)
                {
                    Console.Write(letras[i] + " ");
                }
                Console.WriteLine();

                // Invertir manualmente
                Console.WriteLine("Vector invertido:");
                for (int i = letras.Length - 1; i >= 0; i--)
                {
                    Console.Write(letras[i] + " ");
                }
                Console.WriteLine();*/










                /* int[] vector = new int[20];
                 Random rnd = new Random();

                 // Llenar vector
                 for (int i = 0; i < vector.Length; i++)
                 {
                     vector[i] = rnd.Next(0, 51);
                 }

                 // Mostrar vector
                 Console.WriteLine("Vector:");
                 for (int i = 0; i < vector.Length; i++)
                 {
                     Console.Write(vector[i] + " ");
                 }
                 Console.WriteLine();

                 // Buscar número
                 Console.Write("Ingrese un número a buscar: ");
                 int buscar = int.Parse(Console.ReadLine());
                 bool encontrado = false;

                 for (int i = 0; i < vector.Length; i++)
                 {
                     if (vector[i] == buscar)
                     {
                         Console.WriteLine("Número " + buscar + " encontrado en la posición " + i);
                         encontrado = true;
                         break;
                     }
                 }

                 if (!encontrado)
                 {
                     Console.WriteLine("-1");
                 }
             */










                /* Console.Write("Ingrese tamaño del vector (impar, >1): ");
                   int n = int.Parse(Console.ReadLine());

                   if (n % 2 == 0 || n <= 1)
                   {
                       Console.WriteLine("El rango debe ser impar y mayor que 1.");
                       return;
                   }

                    int[] vector = new int[n];
                   int mitad = n / 2;

                   Console.Write("Ingrese un número para la mitad: ");
                   int num = int.Parse(Console.ReadLine());
                   vector[mitad] = num;

                   // Menores en la primera mitad
                   for (int i = 0; i < mitad; i++)
                   {
                       vector[i] = num - (mitad - i);
                   }

                   // Mayores en la segunda mitad
                   for (int i = mitad + 1; i < n; i++)
                   {
                       vector[i] = num + (i - mitad);
                   }

                   // Mostrar vector
                   Console.WriteLine("Vector final:");
                   for (int i = 0; i < vector.Length; i++)
                   {
                       Console.Write(vector[i] + " ");
                   }
                   Console.WriteLine();*/




                /* Console.Write("Ingrese tamaño del primer vector: ");
                 int n1 = int.Parse(Console.ReadLine());
                 Console.Write("Ingrese tamaño del segundo vector: ");
                 int n2 = int.Parse(Console.ReadLine());

                 int[] v1 = new int[n1];
                 int[] v2 = new int[n2];
                 int[] combinado = new int[n1 + n2];
                  Random rnd = new Random();

                 // Llenar primer vector (0 a n1+1)
                 for (int i = 0; i < n1; i++)
                 {
                     v1[i] = rnd.Next(0, n1 + 2);
                 }

                 // Llenar segundo vector (0 a n2*2)
                 for (int i = 0; i < n2; i++)
                 {
                     v2[i] = rnd.Next(0, n2 * 2 + 1);
                 }

                 // Combinar
                 for (int i = 0; i < n1; i++)
                 {
                     combinado[i] = v1[i];
                 }
                 for (int i = 0; i < n2; i++)
                 {
                     combinado[n1 + i] = v2[i];
                 }

                 // Mostrar vectores
                 Console.WriteLine("Vector 1:");
                 for (int i = 0; i < v1.Length; i++)
                 {
                     Console.Write(v1[i] + " ");
                 }
                 Console.WriteLine();

                 Console.WriteLine("Vector 2:");
                 for (int i = 0; i < v2.Length; i++)
                 {
                     Console.Write(v2[i] + " ");
                 }
                 Console.WriteLine();

                 Console.WriteLine("Vector Combinado:");
                 for (int i = 0; i < combinado.Length; i++)
                 {
                     Console.Write(combinado[i] + " ");
                 }
                 Console.WriteLine();
                */
            }
        }
    }
