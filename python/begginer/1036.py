import math

value_a, value_b , value_c = map(float, input().split())

     
def calc_delta():
    delta = (value_b ** 2) - 4 * value_a * value_c
    
    return delta

def bhaskara():
    if value_a == 0:
        print('Impossivel calcular')
        return 
    
    delta = calc_delta()

    if delta < 0:
        print('Impossivel calcular')
        return
    
    R1 = (- value_b + (math.sqrt(delta))) / (2 * value_a)
    R2 = (- value_b - (math.sqrt(delta))) / (2 * value_a)

    print('R1 = {:.5f}'.format(R1))
    print('R2 = {:.5f}'.format(R2))

value = bhaskara()
