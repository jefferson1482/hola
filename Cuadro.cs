using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffersonVera3A.Programas
{
    class Cuadro
    {
        /*2.	Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos con ese  tamaño.        
        Los asteriscos sólo se verán en el borde del cuadrado, no en el interior.*/
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Numero del cuadro");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            { Console.Write(" *"); }

            Console.Write("\n");

            for (int j = 2; j <= n; j++)
            {
                Console.Write(" *");
                for (int i = 2; i < n; i++)
                {
                    Console.Write("  ");
                }
                Console.Write(" * \n");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(" *");
            }
            Console.ReadKey();
        }
    }
}
