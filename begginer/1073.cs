/*
beecrowd | 1073
Quadrado de Pares

Timelimit: 1
Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, 
inclusive N, se for o caso.

Entrada
A entrada contém um valor inteiro N (5 < N < 2000).

Saída
Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.

*/

using System;

class Program
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());

        for (int i = 1; i <= value; i++)
        {
            if (i % 2 == 0)
            {
                int result = i * i;
                Console.WriteLine("{0}^2 = {1}", i, result);
            }
        }
    }
}