package begginer;

import java.util.Scanner;

public class ConversaoTempo {
    public static void main(String[] args) {
        try(Scanner scanner = new Scanner(System.in)) {
            int valueInSeconds = scanner.nextInt();

            int hours = valueInSeconds / 3600;
            valueInSeconds %= 3600;

            int minutes = valueInSeconds / 60;
            valueInSeconds %= 60;

            System.out.println(String.format("%d:%d:%d", hours, minutes, valueInSeconds));
        }
    }
}
