using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffersonVera3A.Programas
{
    class NUmeros_del_100_al_1_y_del_1_al_100
    {
        //7.	Crear un programa que escriba dos columnas de números, en la primera se colocan los números del 1 al 100,
        //en la segunda los números del 100 al 1 
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i--)
                Console.Write("{0}|", i);
            Console.Write("\t\t");
            for (int i = 1; i < 101; i++)
                Console.Write("{0}|", i);
            Console.ReadKey();
        }
    }
}
