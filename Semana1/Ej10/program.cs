using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Idiomas
{
    class Idiomas
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 4];
            int LONG_FILA_MATRIZ = 3;
            int LONG_COLUMNA_MATRIZ = 4;
            

            for (int a = 0; a < LONG_FILA_MATRIZ; a++)
            {
                for (int b = 0; b < LONG_COLUMNA_MATRIZ; b++)
                {
                    Console.Write("Digite el elemnto {a+ 1}, {b + 1} de la matriz");
                    mat[a, b] = int.Parse(System.Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz que resulta es");



            for (int a = 0; a < LONG_FILA_MATRIZ; a++)
            {
                for (int b = 0; b < LONG_COLUMNA_MATRIZ; b++)
                {
                    Console.Write("[" +mat[a, b] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}

