using System;

class Program
{
    static void Main(string[] args)
    {
        int E = int.Parse(Console.ReadLine());

        for (int i = 0; i < E; i++)
        {
            int D = int.Parse(Console.ReadLine());
            int sensor = DeterminarSensor(D);
            Console.WriteLine(sensor);
        }
    }
    static int DeterminarSensor(int D)
    {
        int posicao = (D - 1) % 8 + 1;

        if (posicao == 1 || posicao == 7)
            return 2;
        else if (posicao == 2 || posicao == 6)
            return 1;
        else
            return 3;
    }
}