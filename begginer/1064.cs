/*
beecrowd | 1064
Positivos e Média

Timelimit: 1
Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. 
Na próxima linha, deve-se mostrar a média de todos os valores positivos 
digitados, com um dígito após o ponto decimal.

Entrada
A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. 
Pelo menos um destes números será positivo.

Saída
O primeiro valor de saída é a quantidade de valores positivos. A próxima 
linha deve mostrar a média dos valores positivos digitados.
*/

using System;

class Program
{
    static void Main()
    {
        double media = 0;
        double sum = 0;
        int total_positive_values = 0;

        for (int i = 0; i < 6; i++)
        {
            double value = double.Parse(Console.ReadLine());

            if (value > 0)
            {
                sum += value;
                total_positive_values++;
            }
        }

        media = sum / total_positive_values;

        Console.WriteLine("{0} valores positivos", total_positive_values);
        Console.WriteLine("{0:F1}", media);
    }
}