/*
beecrowd | 1059
Números Pares

Timelimit: 1
Faça um programa que mostre os números pares entre 1 e 100, inclusive.

Entrada
Neste problema extremamente simples de repetição não há entrada.

Saída
Imprima todos os números pares entre 1 e 100, inclusive se for o caso, um em cada linha.
*/

using System;

class Program {
    public static void Main() {
        for(int i = 1; i <= 100; i++) {
            if(i % 2 == 0) {
                Console.WriteLine(i);
            }
        }
    }
}