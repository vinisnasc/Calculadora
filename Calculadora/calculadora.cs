using System;

namespace Calculadora
{
    /// <summary>
    /// Algoritmo de cálculo de alcance de publicidade.
    /// </summary>
    class Calculadora
    {
        static void Main(string[] args)
        {
            // Define o valor do investimento.
            Console.WriteLine("Qual o valor investido?");
            double invest = double.Parse(Console.ReadLine());

            // Calcula a quantidade de visualização de acordo com o valor investido,
            // sendo considerado quatro o maximo de compartilhamento no loop.
            double vis = invest * 30;
            double nvis = vis;
            double totalvis = vis;

            for (int i = 0; i < 4; i++)
            {
                double clique = nvis * 0.12;
                double comp = clique * 0.15;
                nvis = comp * 40;
                totalvis += nvis;
            }

            // Printa o resultado do cálculo, apresentando o valor investido e o alcance da publicação.
            Console.WriteLine($"\nCom o valor de R$ {invest} investido, " +
                $"o total de visualizações será de aproximadamente {Math.Round(totalvis)}.");
        }
    }
}

        