using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            int[] Idades = new int[7];

            for(int i = 0; i <= 6; i++)
            {  
               
                Console.Write("Idade: ");
                Idades[i] = Convert.ToInt32(Console.ReadLine());



            }
            Console.Clear();

            Console.WriteLine("                1° Idade: " + Idades[0] +
            "\n                2° Idade: " + Idades[1] +
            "\n                3° Idade: " + Idades[2] +
            "\n                4° Idade: " + Idades[3] +
            "\n                5° Idade: " + Idades[4] +
            "\n                6° Idade: " + Idades[5] +
            "\n                7° Idade: " + Idades[6]);


        }
    }
}
