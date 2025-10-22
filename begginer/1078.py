'''
beecrowd | 1078
Tabuada

Timelimit: 1
Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:      
1 x N = N      2 x N = 2N        ...       10 x N = 10N

Entrada
A entrada contém um valor inteiro N (2 < N < 1000).
'''

value = int(input())

for i in range(1, 11):
    multiplication_table = i * value
    print(f"{i} x {value} = {multiplication_table}")