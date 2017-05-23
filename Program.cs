using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForANIDADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cuando tengo un FOR dentro de otro, el de adentro realiza todas sus iteraciones, por
            //cada iteración del de afuera.

            Console.Write("\n * Ejemplo de FOR ANIDADO *\n\n");

            int contAux = 0;
            for (int i = 1; i <= 10; i++)
            {
                contAux++;
                for (int cont = 5; cont <= 8; cont++)
                {
                    contAux++;
                    Console.Write(" | " + cont + " - " + i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n - El contador auxiliar vale: " + contAux);
            Console.ReadLine();
        }
    }
}
