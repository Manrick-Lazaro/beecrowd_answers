/*
beecrowd | 3301
Sobrinho do Meio

Tio Patinhas era um milionário que vivia em sua mansão, e tinha três sobrinhos: Huguinho, Zezinho e Luisinho. 
Ele se confundia facilmente entre os três sobrinhos, pois eram bem parecidos, apesar de terem idades diferentes. 
Um dia, os três fizeram uma aposta com o tio: se ele acertasse quem era o sobrinho do meio, ou seja, nem o mais novo, 
nem o mais velho, eles dariam uma moeda de ouro para ele, e se ele errasse, teria que dar uma moeda de ouro para 
cada um. Assim, o tio pede a tua ajuda para que ele possa ganhar essa aposta.

Entrada
A entrada consiste em vários casos de teste. Cada caso contém três valores inteiros H, Z e L, que representam as 
idades de Huguinho, Zezinho e Luisinho, respectivamente. 

Saída
Para cada caso de teste imprima o nome do sobrinho do meio, com letras minúsculas.
*/

using System;

class Program {
 static void Main() {
    string input = Console.ReadLine();

    string[] values = input.Split(' ');

    int huguinho = int.Parse(values[0]);
    int zezinho = int.Parse(values[1]);
    int luisinho = int.Parse(values[2]);

    if(huguinho >= zezinho && huguinho <= luisinho || huguinho >= luisinho && huguinho <= zezinho) {
        Console.WriteLine("huguinho");
        return;
    }

    if(zezinho >= huguinho && zezinho <= luisinho || zezinho >= luisinho && zezinho <= huguinho) {
        Console.WriteLine("zezinho");
        return;
    }

    if(luisinho >= huguinho && luisinho <= zezinho || luisinho >= zezinho && luisinho <= huguinho) {
        Console.WriteLine("luisinho");
        return;
    }
 }
}