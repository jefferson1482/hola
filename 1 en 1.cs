using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffersonVera3A.Programas
{
    class _1_en_1
    {
        /*8.	Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. 
       La primera cuenta desde uno hasta el número escrito contando de uno en uno; 
       la segunda columna cuenta de dos en dos y la tercera de tres*/

            static void Main(string[] args)
            {
                int n = 0;
                Console.WriteLine("Ingrese el numero");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("1 en 1");
                    Console.WriteLine(i + " ");
                }
                for (int i2 = 1; i2 <= n; i2 += 2)
                {
                    Console.WriteLine("2 en 2");
                    Console.WriteLine("\t " + i2);
                }
                for (int i3 = 1; i3 <= n; i3 += 3)
                {
                    Console.WriteLine("3 en 3");
                    Console.WriteLine(i3);
                }
                Console.ReadKey();
            }
    }
}
