using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffersonVera3A.Programas
{
    class Factura
    {
        private static decimal r;

        //3.	Crear un programa que lea cantidades y precios y al final indique el total de la factura. 
        static void Main(string[] args)
        {
            int cantidad = 0;
            decimal precio = 0 , r = 0;
            Console.WriteLine("Ingrese la cantidad");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio");
            precio = NewMethod();

            r = cantidad * precio;
            Console.WriteLine("La facture es :" + "$" + r + ".0");

            Console.ReadKey();

        }

        private static decimal NewMethod()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
