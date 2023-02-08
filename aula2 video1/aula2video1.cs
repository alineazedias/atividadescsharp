using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    struct Professor
    {
        public string Matricula;
        public string Nome;
        public Disciplina DadosDisciplina;
    }

    struct Disciplina
    {
        public string NomeDisciplina;
        public int CargaHorária;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor[] xProf = new Professor[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nMatrícula do Professor: ");
                xProf[i].Matricula = Console.ReadLine();

                Console.Write("Nome.....................: ");
                xProf[i].Nome = Console.ReadLine();

                Console.Write("Disciplina...............: ");
                xProf[i].DadosDisciplina.NomeDisciplina = Console.ReadLine();

                Console.Write("Carga Horária.....................: ");
                xProf[i].DadosDisciplina.CargaHorária = int.Parse(Console.ReadLine());
            }

            ListarTudo(xProf);

            string Nome;
            bool Achou;

            Console.Write("\nDigite o nome de um professor: ");

            Nome = Console.ReadLine();
            Achou = ListaProf(xProf, Nome);

            if (!Achou)
            {
                Console.Write("Professor não existe no cadastro...");
            }
            Console.ReadKey();
        }
        static void ListarTudo(Professor[] P)
        {
            Console.Clear();

            foreach (Professor x in P)
            {
                Console.WriteLine($"\n{x.Nome} - ({x.Matricula})");
                Console.WriteLine($"Disciplina: {x.DadosDisciplina.NomeDisciplina}");
                Console.WriteLine($"CH: {x.DadosDisciplina.CargaHorária} Horas");
            }
            Console.ReadKey();
        }

        static bool ListaProf(Professor[] P, string Nome)
        {
            Console.Clear();

            bool Achou = false;

            foreach (Professor x in P)
            {
                if (x.Nome == Nome)
                {
                    Console.WriteLine($"\n{x.Nome} - ({x.Matricula})");
                    Console.WriteLine($"Disciplina: {x.DadosDisciplina.NomeDisciplina}");
                    Console.WriteLine($"CH: {x.DadosDisciplina.CargaHorária} Horas");

                    Achou = true;
                }
            }
            return Achou;

        }

    }
}

