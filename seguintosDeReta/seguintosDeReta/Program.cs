using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguintosDeReta
{
    internal class Exercicio29
    {
        static void Main(string[] args)
        {
            /*25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta.
            Analise seus comprimentos e diga se é possível formar um triângulo com essas
            retas.Matematicamente, para três segmentos formarem um triângulo, o comprimento
            de cada lado deve ser menor que a soma dos outros dois.*/

            Console.Write("Informe o valor do primeiro seguimento: ");
            double seg1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do segundo seguimento: ");
            double seg2 = double.Parse(Console.ReadLine());
            Console.Write("Agora informe o valor do terceiro seguimento: ");
            double seg3 = double.Parse(Console.ReadLine());
            //
            //Processamento dos dados e condição para formar um triângulo
            if (seg1 >= seg2 + seg3)
            {
                Console.WriteLine("Não~é possível formar um triângulo com os valores informados!");
            }
            else
            {
                Console.WriteLine($"Você conseguiu formar um triângulo, pois o a soma de {seg2} e {seg3} é maior que a base ({seg1}) informada.\nVeja:\nBase: {seg1} < que a soma de ({seg2} + {seg3})");
            }
            Console.ReadKey();
        }
    }
}
