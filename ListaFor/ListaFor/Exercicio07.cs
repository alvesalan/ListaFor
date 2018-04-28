using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio07
    {
        public Exercicio07()
        {
            int SomaConsoantes = 0, SomaVogais = 0;

            string[] Caracteres = new string[10];

            for (int i = 0; i < Caracteres.Length; i++)
            {
                Console.Write("Caracter: ");
                Caracteres[i] = Console.ReadLine();
            }

            // Soma consoantes
            for (int i = 0; i < Caracteres.Length; i++)
            {
                if (Caracteres[i] == "b")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }

                else if (Caracteres[i] == "c")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "d")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "f")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "g")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "h")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "j")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "k")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "l")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "m")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "n")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "p")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "q")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "r")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "s")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "t")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "v")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "w")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "x")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "y")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }
                else if (Caracteres[i] == "z")
                {
                    SomaConsoantes = SomaConsoantes + 1;
                }


                // Soma vogais

                if (Caracteres[i] == "a")
                {
                    SomaVogais = SomaVogais + 1;
                }
                else if (Caracteres[i] == "e")
                {
                    SomaVogais = SomaVogais + 1;
                }
                else if (Caracteres[i] == "i")
                {
                    SomaVogais = SomaVogais + 1;
                }
                else if(Caracteres[i] == "o")
                {
                    SomaVogais = SomaVogais + 1;
                }
                else if(Caracteres[i] == "u")
                {
                    SomaVogais = SomaVogais + 1;
                }
                //A – E  – I – O – U           
            }

            Console.WriteLine();
            Console.WriteLine("Soma das consoantes: " + SomaConsoantes);
            Console.WriteLine("Soma das vogais: " + SomaVogais);
            Console.ReadKey();
        }
    }
}
