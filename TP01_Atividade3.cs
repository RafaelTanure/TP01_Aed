using System;

class Program {
    public static void Main (string[] args) {
      
      string[] posExe = Console.ReadLine().Split(' ');

        int N = int.Parse(posExe[0]);
        int M = int.Parse(posExe[1]);

        if (N > 0 && N <= 200000 && M > 0 && M <= 200000) {
            int[] vetor = new int[N];

            for (int i = 0; i < N; i++) {
                vetor[i] = 0;
            }

            for (int i = 0; i < M; i++) {
                string valores = Console.ReadLine();
                string[] posicao = valores.Split(' ');

              
                int comando = int.Parse(posicao[0]);
                int indice = int.Parse(posicao[1])-1;
                int valor = 0;
              
                if (posicao.Length == 3)
                {
                  valor = int.Parse(posicao[2]);
                }

              


                if (comando == 1) {
                    for (int j = 0; j < valor && (indice+j)<N; j++) {
                        vetor[indice + j] = vetor[indice + j] + Convert.ToInt32(posicao[2]);
                        posicao[2] = Convert.ToString(Convert.ToInt32(posicao[2]) - 1);
                    }
                }
                else if (comando == 2) {
                    for (int j = 0; j < valor  && indice-j>=0; j++) {
                      vetor[indice - j] = vetor[indice - j] + Convert.ToInt32(posicao[2]);
                      posicao[2] = Convert.ToString(Convert.ToInt32(posicao[2]) - 1);
                    }
                }
                else if (comando == 3) {

                   Console.WriteLine(vetor[indice]);

                }
              /*for (int x = 0; x < N; x++) {
                Console.WriteLine(vetor[x]);
              }*/     
            }
        }
    }
}