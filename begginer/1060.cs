/*
beecrowd | 1060
Números Positivos

Faça um programa que leia 6 valores. Estes valores serão somente negativos ou 
positivos (desconsidere os valores nulos). A seguir, mostre a quantidade de valores 
positivos digitados.

Entrada
Seis valores, negativos e/ou positivos.

Saída
Imprima uma mensagem dizendo quantos valores positivos foram lidos.
*/

using System;

class Program
{
    static void Main()
    {
        int positive_values = 0;

        for (int i = 0; i < 6; i++)
        {
            double value = double.Parse(Console.ReadLine());

            if (value > 0)
            {
                positive_values++;
            }
        }

        Console.WriteLine("{0} valores positivos", positive_values);
    }
}