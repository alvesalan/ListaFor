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
            double Soma = 0, SomaPares = 0;
            double[] Numeros = new double[4];

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
            }
            Console.WriteLine("");
            Console.WriteLine("Soma dos numeros é: " + Soma);
            Console.WriteLine("Media dos numeros é: " + Media);
            Console.WriteLine("Quantidade de numeros pares: " + SomaPares);

            Console.ReadKey();


        }
    }
}
