using System;
using System.IO;
using System.Globalization;

namespace P8DiaryEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;

            CultureInfo culture = new CultureInfo("es-MX");

            string fechaActualAsStr = fechaActual.ToString(culture);

            Console.WriteLine("Porfavor ingresa la entrada que quieras agregar a tu diario");
            
            string texto = Console.ReadLine();

            using(StreamWriter sw = new StreamWriter("diario.txt"))
            {
                sw.WriteLine(texto);

                sw.WriteLine("Fecha en la que se agrego esta entrada: ");

                sw.WriteLine(fechaActualAsStr);
            }

            Console.WriteLine("Se ah terminado de agregar la entrada.");

        }
    }
}
