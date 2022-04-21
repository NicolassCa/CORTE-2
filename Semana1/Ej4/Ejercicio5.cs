using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicios
{
    class Program
  {
        static void Main(string[] args)
        {
            int i, N;
            int contMas = 0, contMenos = 0;
            double media = 0;


            Console.WriteLine("¿Cual es el numero de personas?");
            N=int.Parse(Console.ReadLine());

            double[] alto = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Persona" + (i + 1) + "=");
                alto[i] = double.Parse(Console.ReadLine());
                media = media + alto[i];
            }

            media = media / N;

            for (i = 0; i < alto.Length; i++)
            {
                if (alto[i] > media)
                { //si la estatura es mayor que la media
                    contMas++;
                }
                else if (alto[i] < media)
                { //si es menor
                    contMenos++;
                }
            }

            Console.WriteLine("Estatura media: " + media);
            Console.WriteLine("Personas con estatura superior a la media: " + contMas);
            Console.WriteLine("Personas con estatura inferior a la media: " + contMenos);



        }

    }
}

    
    
