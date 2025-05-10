value_a , value_b, value_c = map(float, input().split())

triangle_area = (value_a * value_c) / 2
circle_area = 3.14159 * (value_c ** 2)
trepaze_area = (value_a + value_b) * (value_c / 2)
square_area = value_b ** 2
retangle_area = value_a * value_b

print('TRIANGULO: {:.3f}'.format(triangle_area))
print('CIRCULO: {:.3f}'.format(circle_area))
print('TRAPEZIO: {:.3f}'.format(trepaze_area))
print('QUADRADO: {:.3f}'.format(square_area))
print('RETANGULO: {:.3f}'.format(retangle_area))