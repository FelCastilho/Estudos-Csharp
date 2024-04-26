using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Felipe";
            p1.sobrenome = "Coutinho";
            p1.anoNascimento = 2001;
            //Metodo simples
            p1.Cumprimentar();

            Pessoa p2 = new Pessoa()
            {
                nome = "Miguel",
                sobrenome = "Coutinho",
                anoNascimento = 2010,
            };
        }
    }
}
