using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Precio_total
{
    class Program
    {
        static void Main(string[] args)
        {
            short peso_cafe;
            short bolsas_vendidas;
            short precio_libra_cafe;
            float Subtotal;
            double precio_total;

            Console.WriteLine("Escribir el peso del cafe en libras");
            peso_cafe = short.Parse(Console.ReadLine());
            Console.WriteLine("Escribir el numero de bolsas de cafe vendidas");
            bolsas_vendidas = short.Parse(Console.ReadLine());
            Console.WriteLine("Escribir el precio de cada libra de cafe");
            precio_libra_cafe = short.Parse(Console.ReadLine());
            Subtotal = (bolsas_vendidas * peso_cafe) * precio_libra_cafe;
            precio_total = Subtotal + (Subtotal * 0.15);

            Console.WriteLine("Su precio total es de:" + precio_total + "C$");
            Console.Read();

        }
    }
}
