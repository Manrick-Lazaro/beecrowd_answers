/*
beecrowd | 1044
Múltiplos

Timelimit: 1
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

Entrada
A entrada contém valores inteiros.

Saída
A saída deve conter uma das mensagens conforme descrito acima.
*/

using System;

class Program {
    static void Main()
    {
        string input = Console.ReadLine();
        string[] values = input.Split(' ');

        int value_A = int.Parse(values[0]);
        int value_B = int.Parse(values[1]);

        if (value_B > value_A)
        {
            int aux = value_A;
            value_A = value_B;
            value_B = aux;
        }

        if (value_A % value_B == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}