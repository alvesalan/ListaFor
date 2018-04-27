using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.Write("Quantos jogos gostaria de cadastrar: ");
            int QuantidadeCadastro = Convert.ToInt32(Console.ReadLine());

            string[] NomesJogos = new string[QuantidadeCadastro];
            int[] Estoque = new int[QuantidadeCadastro];

            for(int i = 0; i < QuantidadeCadastro; i++)
            {
                Console.Write("Nome do jogo: ");
                NomesJogos[i] = Console.ReadLine();

                Console.Write("Quantidade no estoque: ");
                Estoque[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            for(int i = 0; i < QuantidadeCadastro; i++)
            {
                Console.WriteLine("Jogo: " + NomesJogos[i] + "    Possui: " +  Estoque[i] + " no estoque");
            }

            Console.ReadKey();
        }
    }
}
