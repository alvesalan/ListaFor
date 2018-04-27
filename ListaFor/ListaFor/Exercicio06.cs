using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            Random rnd = new Random();

            double Soma = 0, SomaPares = 0, SomaPositivos = 0, SomaImpar = 0, SomaNegativo = 0, SomaNeutro = 0;
            double[] Numeros = new double[4];

            // gerador de numero aleatorio

            for (int ctr = 0; ctr <= Numeros.Length; ctr++)
            {
                Console.WriteLine(rnd.Next(int.MinValue, int.MaxValue));
                if (ctr % 5 == 0) ;


            }



            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Write("Numero: ");
                Numeros[i] = Convert.ToDouble(Console.ReadLine());

                Soma = Soma + Numeros[i];
            }

            double Media = Soma / Numeros.Length;

            Console.Clear();

            for(int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine("Numeros armazenados: " + Numeros[i]);
            }

            for (int i = 0; i < Numeros.Length; i++)
            {
                if(Numeros[i] % 2 == 0)
                {
                    SomaPares = SomaPares + 1; 
                }

                if(Numeros[i] > 0)
                {
                    SomaPositivos = SomaPositivos + 1;
                }

                if (Numeros[i] % 2 == 1)
                {
                    SomaImpar = SomaImpar + 1;
                }

                if (Numeros[i] < 0)
                {
                    SomaNegativo = SomaNegativo + 1; 
                }

                if (Numeros[i] == 0)
                {
                    SomaNeutro = SomaNeutro + 1; 
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Soma dos numeros é: " + Soma);
            Console.WriteLine("Media dos numeros é: " + Media);
            Console.WriteLine("Quantidade de numeros pares: " + SomaPares);
            Console.WriteLine("Quantidade dos numeros positivos: " + SomaPositivos);
            Console.WriteLine("Quantidade de numeros impar: " + SomaImpar);
            Console.WriteLine("Quantidade de numeros negativos: " + SomaNegativo);
            Console.WriteLine("Quantidade de numeros neutros: " + SomaNeutro);


            Console.ReadKey();


        }
    }
}
