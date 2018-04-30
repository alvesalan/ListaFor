using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio11
    {
        public Exercicio11()
        {
            string[] Nomes = new string[5];

            for (int i = 0; i < Nomes.Length; i++)
            {
                Console.Write("Nomes: ");
                Nomes[i] = Console.ReadLine();

            }

            Console.WriteLine(Nomes[0]+ ", " + Nomes[1]+ ", " + Nomes[2]+ ", " + Nomes[3]+ " e " + Nomes[4] + "." );
        }
    }
}
