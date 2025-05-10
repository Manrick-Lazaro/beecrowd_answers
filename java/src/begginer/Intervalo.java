package  begginer ;

import java.util.Scanner;

class Intervalo {
    public static void main(String[] args) {
        try(Scanner scanner = new Scanner(System.in)) {
            double value = scanner.nextDouble();

            String intervalMessage = "Fora de intervalo";

            if(value >= 0.0 && value <= 25.0) {
                intervalMessage = "Intervalo [0,25]";
            }

            if(value > 25.0 && value <= 50.0) {
                intervalMessage = "Intervalo (25,50]";
            }

            if(value > 50.0 && value <= 75.0) {
                intervalMessage = "Intervalo (50,75]";
            }

            if(value > 75.0 && value <= 100.0) {
                intervalMessage = "Intervalo (75,100]";
            }

            System.out.println(intervalMessage);
        }
    }
}