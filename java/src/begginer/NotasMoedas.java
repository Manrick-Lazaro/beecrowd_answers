package begginer;

import java.text.DecimalFormat;
import java.util.Scanner;


public class NotasMoedas {
    public static void main(String[] args) {
        try(Scanner scanner = new Scanner(System.in)) {
            DecimalFormat formatter = new DecimalFormat("#");

            double value = scanner.nextDouble();

            int[] cedulas = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            cedulas[0] = (int) (value / 100);
            double remainder = value % 100;

            cedulas[1] = (int) (remainder / 50);
            remainder %= 50;

            cedulas[2] = (int) (remainder / 20);
            remainder %= 20;
            
            cedulas[3] = (int) (remainder / 10);
            remainder %= 10;
            
            cedulas[4] = (int) (remainder / 5);
            remainder %= 5;

            cedulas[5] = (int) (remainder / 2);
            remainder %= 2;

            cedulas[6] = (int) (remainder / 1);
            remainder %= 1;

            cedulas[7] = (int) (remainder / 0.50);
            remainder %= 0.50;

            cedulas[8] = (int) (remainder / 0.25);
            remainder %= 0.25;

            cedulas[9] = (int) (remainder / 0.10);
            remainder %= 0.10;

            cedulas[10] = (int) (remainder / 0.05);
            remainder %= 0.05;

            System.out.println("NOTAS:");   

            System.out.println((String.format("%d nota(s) de R$ 100.00", cedulas[0])));
            System.out.println((String.format("%d nota(s) de R$ 50.00", cedulas[1])));
            System.out.println((String.format("%d nota(s) de R$ 20.00", cedulas[2])));
            System.out.println((String.format("%d nota(s) de R$ 10.00", cedulas[3])));
            System.out.println((String.format("%d nota(s) de R$ 5.00", cedulas[4])));
            System.out.println((String.format("%d nota(s) de R$ 2.00", cedulas[5])));

            System.out.println("MOEDAS:"); 
            System.out.println((String.format("%d moeda(s) de R$ 1.00", cedulas[6])));
            System.out.println((String.format("%d moeda(s) de R$ 0.50", cedulas[7])));
            System.out.println((String.format("%d moeda(s) de R$ 0.25", cedulas[8])));
            System.out.println((String.format("%d moeda(s) de R$ 0.10", cedulas[9])));
            System.out.println((String.format("%d moeda(s) de R$ 0.05", cedulas[10])));
            System.out.println(formatter.format(remainder / 0.01) + " moeda(s) de R$ 0.01");
        }
    }
}
