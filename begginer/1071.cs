/*
beecrowd | 1071
Soma de Impares Consecutivos I

Timelimit: 1
Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos 
números impares entre eles.

Entrada
O arquivo de entrada contém dois valores inteiros.

Saída
O programa deve imprimir um valor inteiro. Este valor é a soma dos 
valores ímpares que estão entre os valores fornecidos na entrada que 
deverá caber em um inteiro.
*/

using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int value = 0;

        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }

        for (int i = x + 1; i < y; i++)
        {
            if (i % 2 != 0)
            {
                value += i;
            }
        }

        Console.WriteLine(value);
    }
}