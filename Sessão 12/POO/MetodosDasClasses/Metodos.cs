using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        //Metodos simples 

        public void Cumprimentar()
        {
            //Console.WriteLine("Olá, seja bem vindo!");
        }

 
        #region Métodos com parâmetros
        public void Somar(int n1, int n2)
        {
            int resultado = n1 + n2;

            //Console.WriteLine("A soma é: " + resultado);
        }

        #endregion

        #region Retornos dos metodos
        public string MontarNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }

        public int Character(int nome)
        {
            return nome;
        }
        #endregion
    }
}
