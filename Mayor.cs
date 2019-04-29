using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffersonVera3A.Programas
{
    class Mayor
    {
        //1.	Programa que lea una serie de números por teclado e indique cuál es el mayor.
        static void Main(string[] args)
        {
            int n = 0, canti = 0, mayor = 0;
            Console.WriteLine("Ingresa la cantidad de numero para comparar");
            canti = int.Parse(Console.ReadLine());
            for (int i = 0; i < canti; i++)
            {
                Console.WriteLine("Ingrese el numero");
                n = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = n;
                }
                else if (i != 0)
                {
                    if (n > mayor)
                    {
                        mayor = n;
                    }
                }

            }
            Console.WriteLine("El numero mayor es :" + mayor);
            Console.ReadLine();
        }
    }
}
