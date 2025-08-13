namespace _2.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores Numericos 
            //cambio de signo 

            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;

            Console.WriteLine($"{num1} // {num2} // {num3} // {num4}");

            //OPERADORES ARITMETICOS 

            int num5 = 3 + 5;//suma
            int num6 = 100 - 26;//resta
            int num7 = 4 * 2;//Producto
            //float num8 = (float) 5 / 3;//divicion
            //float num8 = 5f / 8;
            float num8 = 20f / 3f;
            double num9 = 5d / 3;
            decimal num10 = 5 / 3m;

            Console.Write($"suma: {num5}, resta : {num6}, producto: {num7}, divicion: {num8} num9: {num9} num10 {num10}")
                ;

            //operador incremento(++), decremento (--)
            num1++;//num1 = num 1 + 1; incremento
            num2--;
            num3 += 5;
            num4 -= 20;
            num5 += 4;
            num7 /= num1;

            //orden de evaluacion operadores aritmeticos 

            int num11 = 4 * 3 / 2;
            int num12 = 5 / 3 * 5;
            int num13 = (4 + 3) / 2;
            int num14 = 4 * (3 / 2);
            int num15 = 4 + 6 * 3;
            int num16 = 4 + 6 * (2 - 1) / 2;



            Console.Write($"num11: {num11}, num12: {num12}, num13: {num13}, num14: {num14}, num15: {num15}, num 16: {num16}");

            //operaciones logicas
            //conjuncion -AND - &&
            Console.WriteLine("TABLA DE VERDAD CONJUNCION");
            Console.WriteLine($"V && V = {true && true}");
            Console.WriteLine($"V && F = {true && false}");
            Console.WriteLine($"F && V = {false && true}");
            Console.WriteLine($"F && F = {false && false}");

            //Disyuncion -OR - ||
            Console.WriteLine("TABLA DE VERDAD DISYUNCION");
            Console.WriteLine($"V || V = {true || true}");
            Console.WriteLine($"V || F = {true || false}");
            Console.WriteLine($"F || V = {false || true}");
            Console.WriteLine($"F || F = {false || false}");

            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2;
            bool exp4 = exp2 || exp3;
            bool exp5 = !exp4 || exp2;

            Console.WriteLine($"exp1 : {exp1}, exp2 : {exp2}, exp3 : {exp3}, exp4 : {exp4}, exp5 : {exp5},");


        }
    }
}
