namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicional Múltiple

            /*Tiendas La Avenida desea dearrollar un programa que permita ingresar
             por teclado el monto de compra y el dia de la semana, para saber:
            *Si el dia es martes o jueves, se realizara un descuento del 15% por la compra.
            *Si el dia es lunes o miercoles, se realizara un descuento del 10% por la compra.
            *Si el dia es viernes o sabado, se realizara un descuento del 20% por la compra.
            *Si el dia es domingo no se realizara descuento.
            *Visualizar el día, el descuento y el total a pagar por la compra.*/

            float valorCompra = 0;
            float descuento = 0;
            char dia = 'a';

            Console.WriteLine("Ingrese el valor de la compra");
            valorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana: l:lunes, m:martes, x:miercoles, j:jueves, v:viernes, s:sabado, d:domingo");
            dia = Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento = valorCompra*0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es viernes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es sabado, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'd':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es domingo, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
            }

        }
    }
}
