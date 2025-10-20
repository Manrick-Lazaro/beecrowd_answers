'''
beecrowd | 1074
Par ou Ímpar

Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida. Para cada 
valor lido, mostre uma mensagem em inglês dizendo se este valor lido é par (EVEN), ímpar (ODD), 
positivo (POSITIVE) ou negativo (NEGATIVE). No caso do valor ser igual a zero (0), embora a 
descrição correta seja (EVEN NULL), pois por definição zero é par, seu programa deverá 
imprimir apenas NULL.

Entrada
A primeira linha da entrada contém um valor inteiro N(N < 10000) que indica o número de casos de teste. 
Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).

'''

quantity = int(input())
types_number = []

while quantity > 0:
    value = int(input())

    if value == 0:
        types_number.append('NULL')
    elif value % 2 == 0 and value > 0:
        types_number.append("EVEN POSITIVE")
    elif value % 2 == 0 and value < 0:
        types_number.append('EVEN NEGATIVE')
    elif value % 2 != 0 and value > 0:
        types_number.append('ODD POSITIVE')
    elif value % 2 != 0 and value < 0:
        types_number.append('ODD NEGATIVE')

    quantity-= 1

for type_number in types_number:
    print(type_number)