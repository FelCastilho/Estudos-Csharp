using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            //m.Cumprimentar();
            //m.Somar(2, 3);

            string nomeCompleto = m.MontarNome("Felipe", "Coutinho");
            int nome = m.Character('c');

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(nome);

            Console.ReadKey();

        }
    }
}
