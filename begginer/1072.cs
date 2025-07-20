/*
beecrowd | 1072
Intervalo 2

Leia um valor inteiro N. Este valor será a quantidade de valores 
inteiros X que serão lidos em seguida. Mostre quantos destes valores 
X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, 
mostrando essas informações.

Entrada
A primeira linha da entrada contém um valor inteiro N (N < 10000), 
que indica o número de casos de teste. Cada caso de teste a seguir é 
um valor inteiro X (-107 < X <107).
 
Saída
Para cada caso, imprima quantos números estão dentro (in) e 
quantos valores estão fora (out) do intervalo.
*/

using System;

class Program
{
    static void Main()
    {
        int quantity = int.Parse(Console.ReadLine());
        int in_values = 0;
        int out_values = 0;

        for (int i = 0; i < quantity; i++)
        {
            int value = int.Parse(Console.ReadLine());

            if (value >= 10 && value <= 20)
            {
                in_values++;
            }
            else
            {
                out_values++;
            }
        }

        Console.WriteLine("{0} in", in_values);
        Console.WriteLine("{0} out", out_values);
    }
}