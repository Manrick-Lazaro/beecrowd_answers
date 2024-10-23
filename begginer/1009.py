name = input()
salary = float(input())
sail = float(input())

bonus = 0.15 * sail

new_salary = salary + bonus

print('TOTAL = R$ {:.2f}'.format(new_salary) )