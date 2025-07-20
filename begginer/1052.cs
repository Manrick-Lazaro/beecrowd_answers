/*
beecrowd | 1052
Mês

Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este 
valor, deve ser apresentado como resposta o mês do ano por extenso, em 
inglês, com a primeira letra maiúscula.

Entrada
A entrada contém um único valor inteiro.

Saída
Imprima por extenso o nome do mês correspondente ao número existente 
na entrada, com a primeira letra em maiúscula.
*/

using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        string month = "";

        switch (x)
        {
            case 1:
                month = "January";
                break;
            case 2:
                month = "February";
                break;
            case 3:
                month = "March";
                break;
            case 4:
                month = "April";
                break;
            case 5:
                month = "May";
                break;
            case 6:
                month = "June";
                break;
            case 7:
                month = "July";
                break;
            case 8:
                month = "August";
                break;
            case 9:
                month = "September";
                break;
            case 10:
                month = "October";
                break;
            case 11:
                month = "November";
                break;
            case 12:
                month = "December";
                break;

        }

        Console.WriteLine(month);
    }
}