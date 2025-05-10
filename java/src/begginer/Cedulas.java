package begginer;

import java.util.Scanner;

public class Cedulas {
    public static void main(String[] args) {
        try(Scanner scanner = new Scanner(System.in)) {
            int value = scanner.nextInt();

            int[] cedulas = {0, 0, 0, 0, 0, 0, 0};

            cedulas[0] = value / 100;
            double remainder = value % 100;

            cedulas[1] = (int) remainder / 50;
            remainder %= 50;

            cedulas[2] = (int) remainder / 20;
            remainder %= 20;
            
            cedulas[3] = (int) remainder / 10;
            remainder %= 10;
            
            cedulas[4] = (int) remainder / 5;
            remainder %= 5;

            cedulas[5] = (int) remainder / 2;
            remainder %= 2;

            cedulas[6] = (int) remainder;

            System.out.println(value);   

            System.out.println((String.format("%d nota(s) de R$ 100,00", cedulas[0])));
            System.out.println((String.format("%d nota(s) de R$ 50,00", cedulas[1])));
            System.out.println((String.format("%d nota(s) de R$ 20,00", cedulas[2])));
            System.out.println((String.format("%d nota(s) de R$ 10,00", cedulas[3])));
            System.out.println((String.format("%d nota(s) de R$ 5,00", cedulas[4])));
            System.out.println((String.format("%d nota(s) de R$ 2,00", cedulas[5])));
            System.out.println((String.format("%d nota(s) de R$ 1,00", cedulas[6])));
        }
    }
}
