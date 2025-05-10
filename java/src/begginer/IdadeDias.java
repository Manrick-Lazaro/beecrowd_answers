package begginer;

import java.util.Scanner;

public class IdadeDias {
    public static void main(String[] args) {
        try(Scanner scanner = new Scanner(System.in)) {
            int valueInDays = scanner.nextInt();

            int years = valueInDays / 365;
            valueInDays %= 365;

            int months = valueInDays / 30;
            valueInDays %= 30;

            System.out.println(String.format("%d ano(s)", years));
            System.out.println(String.format("%d mes(es)", months));
            System.out.println(String.format("%d dia(s)", valueInDays));

        }
    }
}
