using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffersonVera3A.Programas
{
    class Piramide
    {
        // 5.	Crear el programa asteriscos4 en el que se introduce un número entero y se crea una pirámide de asteriscos.
        // Por ejemplo, si se introduce el 6, el resultado sería:
        static void Main(string[] args)
        {
           
            Console.WriteLine("inserta el nivel de la piramide");
            try
            {
                int nivel = int.Parse(Console.ReadLine());
                int a;
                int espacios;
                for (int i = 1; i <= nivel; i++)
                {
                    StringBuilder final = new StringBuilder();

                    espacios = nivel - i;
                    a = i + (i - 1);
                    for (int i1 = 0; i1 < espacios; i1++)
                        final.Append(" ");

                    for (int i2 = 0; i2 < a; i2++)
                        final.Append("*");

                    Console.WriteLine(final.ToString());

                }
            }
            catch (exception ex)
            {
            }
            Console.ReadLine();
        }
    }
}
