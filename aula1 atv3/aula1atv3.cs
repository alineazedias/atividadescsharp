// 3) Faça um programa que possa cadastrar o nome e o telefone de 30 funcionários de uma empresa.
//  Depois dos dados serem informados o programa deve conter uma opção que sirva para o usuário
//   pesquisar sequencialmente um funcionário e encontrar o seu telefone.


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
            string[,] Cadastro = new string[5, 2];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"\nNome do Funcionário {i + 1}: ");
                Cadastro[i, 0] = Console.ReadLine();

                Console.Write($"Telefone.........: ");
                Cadastro[i, 1] = Console.ReadLine();
            }
            string Nome;
            bool Achou = false;
            Console.Write("\n\nDigite o nome de um funcionário: ");
            Nome = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                if (Cadastro[i, 0] == Nome)
                {
                    Achou = true;
                    Console.WriteLine($"O Telefone desse funcionario é {Cadastro[i, 1]} !");
                }
            }
            if (!Achou)
                Console.WriteLine("Funcionário não cadastrado....");
            Console.ReadKey();
        }

    }
}