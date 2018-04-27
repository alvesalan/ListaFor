using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            string[] Nomes = new string[25];

            for(int i = 0; i <= 4; i++)
            {
                Console.Write("Nome: ");
                Nomes[i] = Console.ReadLine();
            }
           
           
          Console.ReadKey();
        }
    }
}
