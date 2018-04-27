using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            string[] Tamanho = new string[5];


            int TPP = 0, TP = 0, TM = 0, TG = 0, TGG = 0, TXG = 0, TXGG = 0;

            Console.WriteLine(" _________________________________ "+
                            "\n|    |    |    |   |    |    |    |"+ 
                            "\n| PP | P  | M  | G | GG | XG | XGG|"+ 
                            "\n|____|____|____|___|____|____|____|");

            Console.WriteLine("");
            Console.WriteLine("");

            for(int i = 0; i < Tamanho.Length; i++)
            {
                Console.Write("Tamanho da camiseta: ");
                Tamanho[i] = Console.ReadLine();


            }

            Console.WriteLine("");

            for (int i = 0; i < Tamanho.Length; i++)
            {
                if (Tamanho[i] == "pp")
                {
                    TPP = TPP + 1;
                }
                else if (Tamanho[i] == "p")
                {
                    TP = TP + 1;
                }
                else if (Tamanho[i] == "m")
                {
                    TM = TM + 1; 
                }
                else if (Tamanho[i] == "g")
                {
                    TG = TG + 1; 
                }
                else if (Tamanho[i] == "gg")
                {
                    TGG = TGG + 1;
                }
                else if (Tamanho[i] == "xg")
                {
                    TXG = TXG + 1;
                }
                else if (Tamanho[i] == "xgg")
                {
                    TXGG = TXGG + 1;
                }
            }


            for (int i = 0; i < 1; i++)
            {
               

                Console.WriteLine("Tamanho PP  : " + TPP +
                                "\nTamanho P   : " + TP  +
                                "\nTamanho M   : " + TM  +
                                "\nTamanho G   : " + TG  +
                                "\nTamanho GG  : " + TGG + 
                                "\nTamanho XG  : " + TXG +
                                "\nTamanho XGG : " + TXGG); 
            }
        }
    }
}
