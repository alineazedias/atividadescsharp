// 2) Um professor tem uma turma com 50 alunos. Ele vai dar no semestre 3 avaliações. Faça um programa que lance a nota de cada aluno nessas avaliações (considere lançar apenas para 5 alunos para agilizar, claro...).

// a.Mostre a nota total de cada aluno
// b.    Mostre a média da nota da turma em cada uma das provas


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
            int[,] Notas = new int[5, 3];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"\nAluno {i + 1}\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Nota da Prova {j + i}: ");
                    Notas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int Soma;
            double Média;

            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Soma = 0;
                for (int j = 0; j < 3; j++)
                {
                    Soma += Notas[i, j];
                }
                Console.Write($"Nota Final do Aluno {i + 1}; {Soma,3}");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                Soma = 0;
                for (int j = 0; j < 5; j++)
                {
                    Soma += Notas[j, i];
                }
                Console.WriteLine($"Média da Turma na Prova {i + 1}:                {((double)Soma / 5),2:F2}");
            }
            Console.ReadKey();
        }

    }
}