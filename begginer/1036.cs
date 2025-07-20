/*
beecrowd | 1036
Fórmula de Bhaskara

Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
Se não for possível calcular as raízes, mostre a mensagem correspondente 
“Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem 
"Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 
dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. 
Imprima sempre o final de linha após cada mensagem.
*/

using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] values = input.Split(' ');

        double a = double.Parse(values[0]);
        double b = double.Parse(values[1]);
        double c = double.Parse(values[2]);

        double delta = (b * b) - (4 * a * c);

        if (a == 0.0)
        {
            Console.WriteLine("Impossivel calcular");
            return;
        }
        if (delta <= 0)
        {
            Console.WriteLine("Impossivel calcular");
            return;
        }

        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine("R1 = {0:F5}", x1);
        Console.WriteLine("R2 = {0:F5}", x2);
    }
}