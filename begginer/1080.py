'''
beecrowd | 1080
Maior e Posição

Leia 100 valores inteiros. Apresente então o maior valor lido e a 
posição dentre os 100 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.
'''

min_value = -2**31
position = -1

for i in range(1, 101):
    value = int(input())

    if value > min_value:
        min_value = value
        position = i

print(min_value)
print(position)