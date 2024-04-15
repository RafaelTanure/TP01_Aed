using System;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] sides = Console.ReadLine().Split(' ');
            int A = int.Parse(sides[0]);
            int B = int.Parse(sides[1]);
            int C = int.Parse(sides[2]);

            if (IsTriangle(A, B, C))
            {
                Console.WriteLine(ClassifyTriangle(A, B, C));
            }
            else
            {
                Console.WriteLine("n");
            }
        }
    }

    static bool IsTriangle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static char ClassifyTriangle(int a, int b, int c)
    {
        if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
        {
            return 'r';
        }
        else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
        {
            return 'o'; 
        }
        else
        {
            return 'a'; 
        }
    }
}
