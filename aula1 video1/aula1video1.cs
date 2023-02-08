// Estruturas Homogeneas - Criaremos um vetor de números inteiros com 5 posições e ler cada um de seus valores. Criaremos duas funções que, 
// tomando esse vetor como parâmetro, irão retornar a soma dos números pares contidos no vetor e a quantidade de números 
//ímpares que ele possui. 

class Program
{
    static void Main(string[] args)
    {
        int[] Vetor = new int[5]; //declaração do vetor

        //entrada de elementos do vetor
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}o. Elemento do Vetor: ");
            Vetor[i] = int.Parse(Console.ReadLine());
        }

        //variaveis para a soma e para a quantidade
        int Soma;
        int Qtde;

        Soma = SomaPares(Vetor);
        Qtde = ContaImpares(Vetor);

        //agora é só mostrar os resultado...

        Console.WriteLine();

        Console.WriteLine($"Soma dos Números Pares: {Soma}");
        Console.WriteLine($"Quantidade de Numeros Impares: {Qtde}");

        Console.ReadKey();

    }


    //Funções
    static int SomaPares(int[] V)
    {
        int S = 0;              // Variavel para somar os pares

        for (int i = 0; i < 5; i++) // Para cada elemento do vetor
        {
            if (V[i] % 2 == 0)   //ele é o par?
                S += V[i];      //  entao acumula
        }

        return S;               // retorna a soma
    }

    static int ContaImpares(int[] V)
    {
        int Q = 0;          //variavel para contar os impares

        for (int i = 0; i < V.Length; i++)   //para cada elemento do vetor || v.lenght = diz qnts elementos ele tem
        {
            if (V[i] % 2 != 0)       //ele e impar?
                Q++;                //entao conta            
        }
        return Q;                   //retorna a quantidade
    }

}
