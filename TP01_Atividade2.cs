using System;

class Program
{
    static void Main(string[] args)
    {
        string[] sizes = Console.ReadLine().Split();
        int M = int.Parse(sizes[0]);
        int N = int.Parse(sizes[1]);

        int[,] matriz = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            string[] linha = Console.ReadLine().Split();
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(linha[j]);
            }
        }

        bool simetrica = VerificarSimetria(matriz, M, N);

        Console.WriteLine(simetrica ? 1 : 0);
    }

    static bool VerificarSimetria(int[,] matriz, int M, int N)
    {
        if (M != N)
            return false;
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (matriz[i, j] != matriz[j, i])
                    return false;
            }
        }
        return true;
    }
}