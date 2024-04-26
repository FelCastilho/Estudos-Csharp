using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;


        #region Método simples
        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {nome} {sobrenome}");
        }

        #endregion
    }
}
