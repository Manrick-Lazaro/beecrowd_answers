'''
beecrowd | 1075
Resto 2

Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.

Entrada
A entrada contém um valor inteiro N (N < 10000).
'''

value = int(input())

for i in range(1, 10000):
    if i % value == 2:
        print(i)