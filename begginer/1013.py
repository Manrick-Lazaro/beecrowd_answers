value_A, value_B, value_C = map(int, input().split())

maior_AB = (value_A + value_B + (abs(value_A - value_B))) // 2
maior = (maior_AB + value_C + (abs(maior_AB - value_C))) // 2

print('{} eh o maior'.format(maior))
