/*
beecrowd | 1066
Pares, Ímpares, Positivos e Negativos

Timelimit: 1
Leia 5 valores Inteiros. A seguir mostre quantos valores digitados 
foram pares, quantos valores digitados foram ímpares, quantos valores 
digitados foram positivos e quantos valores digitados foram negativos.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída
Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não 
esquecendo o final de linha após cada uma.
*/

using System;

class Program
{
    static void Main()
    {
        int even_values = 0;
        int odd_values = 0;
        int negative_values = 0;
        int positive_values = 0;

        for (int i = 0; i < 5; i++)
        {
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                even_values++;
            }
            else
            {
                odd_values++;
            }

            if (value != 0)
            {
                if (value > 0)
                {
                    positive_values++;
                }
                else
                {
                    negative_values++;
                }
            }
        }

        Console.WriteLine("{0} valor(es) par(es)", even_values);
        Console.WriteLine("{0} valor(es) impar(es)", odd_values);
        Console.WriteLine("{0} valor(es) positivo(s)", positive_values);
        Console.WriteLine("{0} valor(es) negativo(s)", negative_values);
    }
}