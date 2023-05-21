﻿string[] dados = Console.ReadLine().Split(' ');

int M = int.Parse(dados[0]);
int N = int.Parse(dados[1]);

int[,] mat = new int[M,N];

for (int i = 0;i < M; i++)
{
    string[] s = Console.ReadLine().Split(' ');

    for(int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(s[j]);
    }
}

int numero = int.Parse(Console.ReadLine());

for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        if (mat[i, j] == numero)
        {
            Console.WriteLine("Position " + i + "," + j + ":");

            if (j > 0)
            {
                Console.WriteLine("Left: " + mat[i, j - 1]);
            }
            
            if (j < N -1)
            {
                Console.WriteLine("Right: " + mat[i, j + 1]);
            }        
        
            if (i > 0)
            {
                Console.WriteLine("Up: " + mat[i - 1, j]);
            }

            if (i < M - 1)
            {
                Console.WriteLine("Down: " + mat[i + 1, j]);
            }
        }
    }
}