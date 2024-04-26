using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicando_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] result = new int[2, 2];

            Console.WriteLine("Preencha a primeira matriz: ");

            //Percorrendo as linhas
            for (int line = 0; line < 2; line++)
            {
                //Percorrendo as colunas

                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("#1. Posição [" + line + "][" + coluna + "]: ");
                    //Armazenando os valores que estão sendo inseridos pelo user
                    matriz1[line, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencha a segunda matriz: ");

            //Percorrendo as linhas
            for (int line = 0; line < 3; line++)
            {
                //Percorrendo as colunas

                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("#2. Posição [" + line + "][" + coluna + "]: ");
                    //Armazenando os valores que estão sendo inseridos pelo user
                    matriz1[line, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado de matriz #1 x matriz #2");
            result[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            result[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            result[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            result[1, 0] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + result[0, 0] + "][" + result[0, 1] + "]");
            Console.ReadKey();
        }
    }
}
