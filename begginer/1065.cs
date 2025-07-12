/*
beecrowd | 1065
Pares entre Cinco Números

Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.
*/

using System;

class Program
{
    static void Main()
    {
        int total_even_numbers = 0;

        for (int i = 1; i <= 5; i++)
        {
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                total_even_numbers++;
            }
        }

        Console.WriteLine("{0} valores pares", total_even_numbers);
    }
}