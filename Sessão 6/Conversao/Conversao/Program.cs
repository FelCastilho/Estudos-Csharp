using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Conversão implicita

            char letra = 'a';
            int num = letra;

            //Desde que a quantidade de valores de um elemento
            //caiba em outro, é permitida a conversão implícita;

            //Converte para o código numerico
            //Console.WriteLine(num);

            #endregion

            #region Conversao explicita

            //ushort num1 = 500;
            //byte num2 = (byte)num1; //Pode ocorrer perda de dados

            //Console.WriteLine(num2); // Retornar 244 pois 500 está fora do escopo do tipo byte 

            //float n3 = 2500.786f; //Pode ocorrer perda de dados 
            //int n4 = (int)n3;

            //Console.WriteLine(n4); //Retorna somente os itens antes do ponto 

            //char character = (char)97; //Converte o 97 para a letra correspondente = (a)

            //Console.WriteLine(character);

            char nome = 'f';

            int numericValue = (int)nome;

            Console.WriteLine(numericValue);
            #endregion

            #region Método Parse

            //string textNumber = "1985";

            //int n2 = int.Parse(textNumber);

            //Console.WriteLine(n2);  

            //double n3 = double.Parse("123.93"); //Caso possua pontos o compilador irá ignorar da hora da execução

            //Console.WriteLine(n3);

            #endregion

            #region Classe Convert

            string text = Convert.ToString(2500);
            int number = Convert.ToInt32("t"); //Não é possivel 

            Console.WriteLine(text);
            Console.WriteLine(number);

            #endregion
        }
    }
}
