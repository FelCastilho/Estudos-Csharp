using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string primeiroNome, segundoNome, terceiroNome, quartoNome, apoio;


            Console.WriteLine("Digite o primeiro nome:");
            primeiroNome = Console.ReadLine();
            apoio = primeiroNome; //Salvando o valor do primeiro nome para quando ele for trocado não perder;

            Console.WriteLine();

            Console.WriteLine("Digite o segundo nome:");
            segundoNome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite o terceiro nome:");
            terceiroNome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite o quarto nome:");
            quartoNome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Invertendo primeiro e segundo");    
            Console.WriteLine(primeiroNome = segundoNome);

            Console.WriteLine();    

            Console.WriteLine("Invertendo segundo e terceiro");
            Console.WriteLine(segundoNome = terceiroNome);

            Console.WriteLine();

            Console.WriteLine("Invertendo terceiro e quarto");
            Console.WriteLine(terceiroNome = quartoNome);

            Console.WriteLine();

            Console.WriteLine("Invertendo quarto e primeiro");
            Console.WriteLine(quartoNome = apoio);


        }
    }
}
