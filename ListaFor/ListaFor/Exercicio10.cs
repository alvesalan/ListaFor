using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio10
    {
        public Exercicio10()
        {


            int MaiorNome = 0, MenorNome = int.MaxValue;
            string MaiorNomeS = "", MenorNomeS = "", PrimeiroS = "", PrimeiroA = "";
            ;

            string[] Nome = new string[4];
            string[] NomeA = new string[Nome.Length];

            for(int i = 0; i < Nome.Length; i++)
            {
                Console.Write("Nome {0}: ", i + 1);
                Nome[i] = Console.ReadLine();
                NomeA[i] = Nome[i].ToLower();
                


            }

            for (int i = 0; i < Nome.Length; i++)
            {
                if (Nome[i].Length > MaiorNome)
                {
                    MaiorNome = Nome[i].Length;
                    MaiorNomeS = Nome[i];
                }

            }

            for (int i = 0; i < Nome.Length; i++)
            {
                
                if (Nome[i].Length < MenorNome)
                {
                    MenorNome = Nome[i].Length;
                    MenorNomeS = Nome[i]; 
                }
            }

            for (int i = 0; i < Nome.Length; i++)
            {
                if (NomeA[i].Substring(0, 1) == "s")
                {
                    PrimeiroS = Nome[i];
                }

                if (NomeA[i].Substring(0, 1) == "a")
                {
                    PrimeiroA = Nome[i];
                }
            }

            

            

           
            

           

            Console.Clear();


            for (int i = 0; i < Nome.Length; i++)
            {
                Console.WriteLine("Nome {0}: " + Nome[i], i + 1);
            }
            Console.WriteLine("O maior nome: " + MaiorNomeS);
            Console.WriteLine("O menor nome: " + MenorNomeS);
            Console.WriteLine("Nome que começa com (S): " + PrimeiroS);
            Console.WriteLine("Nome que começa com (A): " + PrimeiroA);
            Console.WriteLine("Quantidades de pessoas com sobrenome (Silva): " );
                

            Console.ReadKey();
        }
    }
}
