using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetor - Array Unidimensional

            int[] num = new int[5];

            num[0] = 10; 
            num[1] = 20;
            num[2] = 30;
            num[3] = 50;
            num[4] = 60;

            Console.WriteLine(num[2]);
            Console.ReadKey();

            string[] nomes = new string[3];

            //Inicializando o array
            nomes[0] = "Felipe";
            nomes[1] = "Miguel";
            nomes[2] = "Gohan";

            //Também é possível inicializar com os valores
            string[] nomes2 = {"Alex, Goku, Vegeta"};

            #endregion

            #region Matrizes - Array Bidimensional

            //A vírgula representa o array bidimensional
            int[,] numeros = new int[5, 3]; //Respectivamente linha e coluna

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 40;
            numeros[1, 2] = 40;

            #endregion
        }
    }
}
