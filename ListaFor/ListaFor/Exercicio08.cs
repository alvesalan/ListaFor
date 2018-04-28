using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace ListaFor
{
    internal class Exercicio08
    {
        public Exercicio08()
        {
            Console.Write("Quantos numeros gostaria de armazenar: ");
            int QC = Convert.ToInt32(Console.ReadLine());


            int[] Numeros = new int[QC];
            int[] NumerosPares = new int[QC];
            int[] NumerosImpares = new int[QC];

            for(int i = 0; i < QC; i++)
            {
                Console.Write("Numero {0}: ", i + 1);
                Numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            for (int i =  0; i < QC; i++)
            {
                if (Numeros[i] % 2 == 0)
                {
                    NumerosPares[i] = Numeros[i];
                }  
            }

            for (int i = 0; i < QC; i++)
            {
                if (Numeros[i] % 2 == 1)
                {
                    NumerosImpares[i] = Numeros[i];
                }
            }

            for (int i = 0; i < QC; i++)
            {
                Console.WriteLine("Numeros originais: " + Numeros[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < QC; i++)
            {
                Console.WriteLine("Vetor [" + i + "] " + "pares: " + NumerosPares[i]);
            }

            Console.WriteLine("");

            for(int i = 0; i < QC; i++)
            {
                Console.WriteLine("Vetor [" + i + "] " + "impares: " + NumerosImpares[i]);

            }
            Console.ReadKey();



        }
    }
}