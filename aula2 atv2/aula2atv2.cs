// Faça um programa que possa ser usado por uma clínica para cadastrar: 30 pacientes, 
// a data da consulta, a hora de sua realização, o nome de um paciente e o nome do médico 
// que o atenderá. Depois de os dados serem informados, o programa deve conter uma opção que,
// o usuário fornecendo o nome do médico, liste toda a agenda dele.

// Considere que o atributo Data da consulta” seja também estruturado, formado pelos campos Dia, Mês e Ano.

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    class Paciente
    {
        public string NomePaciente;
        public string NomeMedico;
        public Data DataConsulta;
        public string HoraConsulta;
    }

    class Data
    {
        public string Dia;
        public string Mes;
        public string Ano;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Paciente[] Cadastro = new Paciente[3];      //Vetor com 3 posições para teste

            for (int i = 0; i < 3; i++)
            {
                Paciente x = new Paciente();            //objeto - intancia

                Console.Write($"\nNome do Paciente nr. {i + 1}: ");
                x.NomePaciente = Console.ReadLine();

                Console.Write("Médico................: ");
                x.NomeMedico = Console.ReadLine();

                x.DataConsulta = new Data();        //muito importante - instancia

                Console.Write("Data da Consulta - Dia: ");
                x.DataConsulta.Dia = Console.ReadLine();

                Console.Write("Data da Consulta - Mês: ");
                x.DataConsulta.Mes = Console.ReadLine();

                Console.Write("Data da Consulta - Ano: ");
                x.DataConsulta.Ano = Console.ReadLine();

                Console.Write("Hora da consulta......: ");
                x.HoraConsulta = Console.ReadLine();

                Cadastro[i] = x;            //cadastro feito
            }
            Console.Clear();
            string NomeMedico;
            Console.Write("Digite o nome de um medico: ");
            NomeMedico = Console.ReadLine();

            foreach (Paciente P in Cadastro)
            {
                if (P.NomeMedico == NomeMedico)
                {
                    Console.WriteLine($"\nPaciente: {P.NomePaciente}");
                    Console.WriteLine($"{P.DataConsulta.Dia}/" +
                                      $"{P.DataConsulta.Mes}/" +
                                      $"{P.DataConsulta.Ano} - " +
                                      $"{P.HoraConsulta} Horas");
                }
            }
            Console.ReadKey();
        }

    }
}
