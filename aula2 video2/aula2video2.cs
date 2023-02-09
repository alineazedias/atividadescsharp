using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    class Veiculo                       //classe de tipo
    {
        public string Nome;
        public string Marca;
        public string AnoFab;
        public string Placa;
        public double PreçoFIP;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //vetor para "armazenar" veiculos...
            Veiculo[] CadVeiculo = new Veiculo[3];      //3 veiculos, para exemplo...

            for (int i = 0; i < 3; i++)
            {
                Veiculo x = new Veiculo();              //instancia - atenção...

                Console.Write($"\nNome do veículo{i + i}......: ");
                x.Nome = Console.ReadLine();

                Console.Write("Marca..............: ");
                x.Marca = Console.ReadLine();

                Console.Write("Ano de Fabricação.......: ");
                x.AnoFab = Console.ReadLine();

                Console.Write("Placa..............: ");
                x.Placa = Console.ReadLine();

                Console.Write("Preço tabela FIP.........: ");
                x.PreçoFIP = double.Parse(Console.ReadLine());

                //Vamos colocar o objeto x no vetor, posição i...
                CadVeiculo[i] = x;          //cadastrou!
            }
            Console.Clear();
            //msotrando todos os veiculos cadastrados...

            foreach (Veiculo V in CadVeiculo)
            {
                Console.WriteLine($"\n{V.Nome} - Ano: {V.AnoFab}");
                Console.WriteLine($"Marca: {V.Marca}");
                Console.WriteLine($"Placa: {V.Placa}");
                Console.WriteLine($"Preço - Tabela FIP - R${V.PreçoFIP:F2}");
            }
            Console.ReadKey();


        }
    }
}
