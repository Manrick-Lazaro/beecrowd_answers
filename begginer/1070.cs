/*
beecrowd | 1070
Seis Números Ímpares

Timelimit: 1
Leia um valor inteiro X. Em seguida apresente os 6 valores 
ímpares consecutivos a partir de X, um valor por linha, 
inclusive o X ser for o caso.

Entrada
A entrada será um valor inteiro positivo.

Saída
A saída será uma sequência de seis números ímpares.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        int increased_value = value;

        List<int> list_numbers = new List<int>();

        while (list_numbers.Count < 6)
        {
            if (increased_value % 2 != 0)
            {
                list_numbers.Add(increased_value);
                Console.WriteLine(increased_value);
            }
            increased_value++;
        }
    }
}