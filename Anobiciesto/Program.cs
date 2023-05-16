using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anobiciesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("Ingresa año");
            año = Convert.ToInt32(Console.ReadLine());
            if (año % 4 == 0 && (año % 100 != 0 ||  año % 400 == 0))
            {
                Console.WriteLine("El año " + año + " es bisiesto ");
            }
            else
            {
                Console.WriteLine("El año " + año + " no es bisiesto ");
            }
            Console.ReadLine();
        }
    }
}

