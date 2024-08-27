value = float(input())

match value:
    case _ if 0.0 <= value <= 25.00:
        print('Intervalo [0,25]')
    case _ if 25.01 <= value <= 50.00:
        print('Intervalo (25,50]')
    case _ if 50.01 <= value <= 75.00:
        print('Intervalo (50,75)')
    case _ if 75.01 <= value <= 100.00:
        print('Intervalo (75,100]')
    case _:
        print('Fora de intervalo')