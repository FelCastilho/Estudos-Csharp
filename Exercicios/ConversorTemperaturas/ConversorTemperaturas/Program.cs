using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM VINDO AO CONVERSOR DE TEMPERATURAS");
            Console.Write("Insira a temperatura em Celsius: ");

            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Temperatura em fahrenheit: " + fahrenheit);
            Console.WriteLine("Temperatura em Kelvin: " + kelvin);

            Console.WriteLine("-------------------------------------");

            Console.ReadKey();

        }
    }
}
