'''
beecrowd | 1079
Médias Ponderadas

Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o 
primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

Entrada
O arquivo de entrada contém um valor inteiro N na primeira linha. 
Cada N linha a seguir contém um caso de teste com três valores 
com uma casa decimal cada valor.
'''

test_case = int(input())

for i in range(0, test_case):
    a, b, c = map(float, input().split())

    result = ((a * 2) + (b * 3) + (c * 5)) / 10

    print(f"{result:.1f}")