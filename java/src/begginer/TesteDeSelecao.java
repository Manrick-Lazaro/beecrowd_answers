package begginer;

import java.util.Scanner;

public class TesteDeSelecao {
    public static void main(String[] args) {
        try(Scanner scanner = new Scanner(System.in)) {
            String line = scanner.nextLine();

            String[] values = line.split(" ");

            int[] numbers = new int[values.length];

            for(int i = 0; i < values.length; i++) {
                numbers[i] = Integer.parseInt(values[i]);
            }

            if(numbers[1] > numbers[2] && numbers[3] > numbers[0] && numbers[2] + numbers[3] > numbers[0] + numbers[1] && numbers[2] > 0  && numbers[3] > 0 && numbers[0] % 2 == 0) {
                System.out.println("Valores aceitos");
            } else {
                System.out.println("Valores nao aceitos");
            }
        }
    }
}
