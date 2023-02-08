// Estruturas Homogeneas -Vamos fazer um programa que irá ler os dados de uma matriz de inteiros de ordem 5, 
// ou seja, de dimensões 5x5. Matematicamente ela é chama de matriz quadrada, porque o número de “linhas” 
// é igual ao número de “colunas”. Depois de darmos entrada nos valores da matriz chamaremos uma função que, 
// tomando essa matriz como parâmetro, retornará um vetor composto pelos elementos da diagonal principal dessa matriz quando, então, os listaremos.

class Program
{
    static void Main(string[] args)
    {
        // // Exemplo de Matriz
        //         5   8   3   2   9
        //         9   0   1   4   2
        //         7   8   1   2   0
        //         6   2   6   9   1
        //         3   9   7   2   2   

        // Diagonal Principal da Matriz: 5  0   1   9   2
        // elementos acima da diagonal principal: 8   3   2   9   1   4   2  2   0   1
        // elementos abaixo da diagonal principal: 9    8   6   2   7   2   9   6   3
        // Diagonal Secundaria: 9   4   1   2   3

        // i = index de linha
        // j = index de coluna


        int[,] Matriz = new int[5, 5];      //declaração da matriz
        int[] VetorResultante = new int[5];     //declaração do valor resultante

        for (int i = 0; i < 5; i++)            //para cada linha da matriz
        {
            for (int j = 0; j < 5; j++)         //para cada coluna da matriz
            {
                Console.Write($"Elemento ({i + 1}, {j + 1}): ");

                Matriz[i, j] = int.Parse(Console.ReadLine());  //le o valor do elemento
            }
        }

        //chamada a função
        //envia a matriz e rece como resultado um vetor

        VetorResultante = ExtraiDiagPrinc(Matriz);

        //agora ésó mostrar

        Console.Write("\n\nDiagonal Principal: ");

        for (int i = 0; i < 5; i++)         //para cada colujna da matriz
        {
            Console.Write($"{VetorResultante[i],7}");
        }

        Console.WriteLine("\n");

        Console.ReadKey();
    }

    static int[] ExtraiDiagPrinc(int[,] M)
    {
        int[] Result = new int[5];

        for (int i = 0; i < 5; i++)              //para cada linha da matriz
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == j)                     //estamos na diagonal principal?
                    Result[i] = M[i, j];      //alimentamos o vetor
            }
        }
        return Result;
    }

    //for (int i = 0; i < 5; i++)
    //{
    //Result[i] = M[i,i];
    //}

    //Retornamos

}
