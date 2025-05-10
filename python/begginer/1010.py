code_piece_1, number_of_pieces_1, value_piece_1 = input().split()

code_piece_1 = int(code_piece_1)
number_of_pieces_1 = int(number_of_pieces_1)
value_piece_1 = float(value_piece_1)

code_piece_2, number_of_pieces_2, value_piece_2 = input().split()

code_piece_2 = int(code_piece_2)
number_of_pieces_2 = int(number_of_pieces_2)
value_piece_2 = float(value_piece_2)

total_value_piece_1 = number_of_pieces_1 * value_piece_1
total_value_piece_2 = number_of_pieces_2 * value_piece_2

total = total_value_piece_1 + total_value_piece_2

print('VALOR A PAGAR: R$ {:.2f}'.format(total))
