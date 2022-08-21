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

            /*30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo
            de triângulo será formado:
            -EQUILÁTERO: todos os lados iguais
            -ISÓSCELES: dois lados iguais
            - ESCALENO: todos os lados diferentes*/

            Console.Write("Informe o valor da base do seguimento: ");
            double baSe = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do lado A do seguimento: ");
            double ladoA = double.Parse(Console.ReadLine());
            Console.Write("Agora informe o valor do labo B do seguimento: ");
            double ladoB = double.Parse(Console.ReadLine());
            //
            //Processamento dos dados e condição para formar um triângulo
            if (baSe < ladoA + ladoB)
            {
                Console.WriteLine("Você conseguiu formar um triângulo!");
                if(baSe == ladoA && baSe == ladoB)
                {
                    Console.WriteLine("O tipo de triângulo é EQUILÁTERO!");
                }else if (baSe == ladoA || baSe == ladoB || ladoA == ladoB)
                {
                    Console.WriteLine("O tipo de triângulo é ISÓSCELES");
                }
                else
                {
                    Console.WriteLine("O tipo de triângulo é ESCALENO");
                }
            }
            else
            {
                Console.WriteLine("Não foi possível formar um triângulo com os valores informados.");
            }
            Console.ReadKey();
        }
    }
}
