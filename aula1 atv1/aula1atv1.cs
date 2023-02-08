
// 1) Faça um programa que leia o valor dos elementos de um vetor de inteiros com 10 posições. Depois que os dados forem fornecidos o programa deverá:

// a.    Mostrar o maior e o menor valor do vetor
// b.    Mostrar quantos números pares e quantos números ímpares existem no vetor
// c.    Mostrar a média aritmética dos valores do vetor


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WorkBJA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = new int[10];
            int soma = 0;
            int numPares = 0;
            int numImpares = 0;

            Console.WriteLine("Insira os elementos do vetor: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}: ");
                Vetor[i] = int.Parse(Console.ReadLine());
                soma += Vetor[i];

                if (Vetor[i] % 2 == 0)
                {
                    numPares++;
                }
                else
                {
                    numImpares++;
                }
            }

            int maiorValor = Vetor[0];
            int menorValor = Vetor[0];

            for (int i = 1; i < 10; i++)
            {
                if (Vetor[i] > maiorValor)
                {
                    maiorValor = Vetor[i];
                }
                if (Vetor[i] < menorValor)
                {
                    menorValor = Vetor[i];
                }
            }

            double media = (double)soma / 10;

            Console.WriteLine($"\nMaior Valor: {maiorValor}");
            Console.WriteLine($"\nMenor Valor: {menorValor}");
            Console.WriteLine($"\nNumeros Pares: {numPares}");
            Console.WriteLine($"\nNNumeros Impares: {numImpares}");
            Console.WriteLine($"\nMédia: {media}");

            Console.ReadKey();

        }
    }
}






