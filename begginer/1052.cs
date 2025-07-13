/*
beecrowd | 1051
Imposto de Renda

Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em 
pagar seus impostos, pois sabem que nele não existem políticos corruptos e os 
recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. 
A moeda deste país é o Rombus, cujo símbolo é o R$.

Leia um valor com duas casas decimais, equivalente ao 
salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o 
valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela 
abaixo.

0.00 a 2000.00          | 0
2000.01 a 3000.00'      | 8%
3000.01 a 4500.00       | 18%
+4500                   | 28%

Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas 
sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 
até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido 
(abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que 
resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas 
decimais.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima o texto "R$" seguido de um espaço e do valor total devido de 
Imposto de Renda, com duas casas após o ponto. Se o valor de entrada 
for menor ou igual a 2000, deverá ser impressa a mensagem "Isento".
*/

using System;

class Program
{
    static void Main()
    {
        double income = double.Parse(Console.ReadLine());
        double tax = 0;

        income -= 2000;

        if (income <= 0)
        {
            Console.WriteLine("Isento");
            return;
        }

        if (income - 1000 > 0)
        {
            tax += 1000 * 0.08;
            income -= 1000;
        }
        else
        {
            tax += income * 0.08;
            Console.WriteLine("R$ {0:F2}", tax);
            return;
        }

        if (income - 1500 > 0)
        {
            tax += 1500 * 0.18;
            income -= 1500;
        }
        else
        {
            tax += income * 0.18;
            Console.WriteLine("R$ {0:F2}", tax);
            return;
        }

        if (income > 0)
        {
            tax += income * 0.28;
        }

        Console.WriteLine("R$ {0:F2}", tax);
    }
}
