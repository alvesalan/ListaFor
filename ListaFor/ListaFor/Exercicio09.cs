using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio09
    {
        public Exercicio09()
        {
            double Soma = 0, Media = 0;


            double[] Notas = new double[4];

            for (int i = 0; i < Notas.Length; i++)
            {
                try
                {
                    Console.Write("Nota {0}: ", i + 1);
                    Notas[i] = Convert.ToDouble(Console.ReadLine());

                    Soma = Soma + Notas[i];
                }
                catch (Exception)
                    {
                        
                    { 
                        Console.WriteLine("Digite apenas numero !! ");
                        Console.Write("Digite Novamento a Nota {0}: ", i + 1);
                        Notas[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    }

            }
            Console.Clear();
            Media = Soma / Notas.Length;

            for (int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine("Nota {0}: " + Notas[i], i + 1);

            }
            Console.WriteLine("Media: " + Media);

        }
    }
}
