using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite sua altura: ");

            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine()); 

            if(peso >= 0 && altura >= 0)
            {
                double imc = peso / (altura * altura);

                Console.WriteLine($"Seu IMC: {imc}");
                Console.ReadKey();
            }

            Console.ReadKey();  

        }
    }
}
