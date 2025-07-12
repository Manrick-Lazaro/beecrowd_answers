/*
beecrowd | 1048
Aumento de Salário

A empresa ABC resolveu conceder um aumento de salários a seus 
funcionários de acordo com a tabela abaixo:

Salário	Percentual de Reajuste
0 - 400.00              | 15%
400.01 - 800.00         | 12%
800.01 - 1200.00        | 10%
1200.01 - 2000.00       | 7%
Acima de 2000.00        | 4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem 
como o valor de reajuste ganho e o índice reajustado, em percentual.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste 
(ambos devem ser apresentados com 2 casas decimais) e o percentual de reajuste 
ganho, conforme exemplo abaixo.
*/

using System;

class Program
{
    static void Main()
    {
        double salary = double.Parse(Console.ReadLine());
        double new_salary = 0.0;
        double adjustment = 0.0;
        int percentual = 0;

        if(salary >= 0.00 && salary <= 400.00)
        {
            adjustment = salary * 0.15;
            new_salary = salary + adjustment;
            percentual = 15;
        }
        
        if (salary > 400.00 && salary <= 800.00)
        {
            adjustment = salary * 0.12;
            new_salary = salary + adjustment;
            percentual = 12;
        }

        if(salary > 800.00 && salary <= 1200.00)
        {
            adjustment = salary * 0.10;
            new_salary = salary + adjustment;
            percentual = 10;
        }


        if (salary > 1200.00 && salary <= 2000.00)
        {
            adjustment = salary * 0.07;
            new_salary = salary + adjustment;
            percentual = 7;
        }

        if (salary > 2000.00)
        {
            adjustment = salary * 0.04;
            new_salary = salary + adjustment;
            percentual = 4;
        }

        Console.WriteLine("Novo salario: {0:F2}", new_salary);
        Console.WriteLine("Reajuste ganho: {0:F2}", adjustment);
        Console.WriteLine("Em percentual: {0} %", percentual);
    }
}