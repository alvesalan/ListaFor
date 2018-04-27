using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio03
    {
        public Exercicio03()
        {

            double ValorTotal = 0;
            Console.Write("Quantos registros vai querer fazer: ");
            int Registro = Convert.ToInt32(Console.ReadLine());

            double[] Preços = new double[Registro];



            for (int i = 0; i <= Registro - 1; i++)
            {
                Console.Write("Preço:  ");
                Preços[i] = Convert.ToDouble(Console.ReadLine());

                ValorTotal = ValorTotal + Preços[i];
            
            }

            Console.Clear();


            for (int j = 0; j <= Registro - 1; j++)
            {
                Console.WriteLine("Preços " + (j + 1) + " = " + Preços[j] + " R$");
            }
                Console.WriteLine("Valor Total: " + ValorTotal + "R$");

          




        }
    }
}
