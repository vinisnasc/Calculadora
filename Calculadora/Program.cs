using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor investido?");
            double invest = double.Parse(Console.ReadLine());

            double vis = invest * 30;
            double nvis = vis;
            double totalvis = vis;

            for (int i = 1; i < 4; i++)
            {
                double clique = nvis * 0.12;
                double comp = clique * 0.15;
                nvis = comp * 40;
                totalvis += nvis;
            }

            Console.WriteLine($"O valor de visualização de acordo com o total investido, será de aproximadamente {Math.Round(totalvis)} views.");
        }
    }
}
