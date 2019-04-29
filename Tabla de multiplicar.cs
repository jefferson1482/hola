using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffersonVera3A.Programas
{
    class Tabla_de_multiplicar
    {
        //9.	Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15.
        static void Main(string[] args)
        {
            int n, r;
            String tabla;

            Console.WriteLine("Introdusca el valor a multiplicar");
            tabla = Console.ReadLine();
            n = Convert.ToInt32(tabla);

            for (int x = 1; x <= 15; x++)
            {
                r = n * x;
                Console.WriteLine(n + " * " + x + " = " + r);
            }
            Console.ReadLine();
        }
        
    }
}
