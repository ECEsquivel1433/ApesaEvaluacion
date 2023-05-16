using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerosparoimpar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el primer numero a comparar");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a comparar");
            int num2 = int.Parse(Console.ReadLine());

            if ((num1 % 2) == 0)
            {
                Console.WriteLine("El numero " + num1 + " es par ");
            }
            else
            {
                Console.WriteLine("El numero " + num1 + " es impar");
            }
            if ((num2 % 2) == 0)
            {
                Console.WriteLine("El numero " + num2 + " es par ");
            }
            else
            {
                Console.WriteLine("El numero " + num2 + " es impar");
            }
            Console.ReadLine();
        }
    }
}
