using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertirafecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fecha;
            Console.WriteLine("Ingrese la fecha: ");
            string fecha = Console.ReadLine();
            char[] letra = new char[fecha.Length];
            string[] datos = new string[3];
            int i = 0;
            foreach (char porl in fecha)
            {
                letra[i] = porl;
                i++;
            }
            datos[0] = letra[0].ToString() + letra[1].ToString();
            datos[1] = letra[2].ToString() + letra[3].ToString();
            datos[2] = letra[4].ToString() + letra[5].ToString();
            switch (datos[1])
            {
                case "01":
                    datos[1] = "Enero";
                    break;
                case "02":
                    datos[1] = "Febrero";
                    break;
                case "03":
                    datos[1] = "Marzo";
                    break;
                case "04":
                    datos[1] = "Abril";
                    break;
                case "05":
                    datos[1] = "Mayo";
                    break;
                case "06":
                    datos[1] = "Junio";
                    break;
                case "07":
                    datos[1] = "Julio";
                    break;
                case "08":
                    datos[1] = "Agosto";
                    break;
                case "09":
                    datos[1] = "Septiembre";
                    break;
                case "10":
                    datos[1] = "Octubre";
                    break;
                case "11":
                    datos[1] = "Noviembre";
                    break;
                case "12":
                    datos[1] = "Diciembre";
                    break;
                default:
                    break;
            }
            int fourDigitYear = CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(Convert.ToInt32(datos[0]));
            Console.WriteLine(datos[2] + "/" + datos[1] + "/" + fourDigitYear);
            Console.ReadKey();
        }
    }
}
