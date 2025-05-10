package begginer;

import java.text.DecimalFormat;
import java.text.DecimalFormatSymbols;
import java.util.Scanner;

public class GastoDeCombustivel {
    public static void main(String[] args) {
        try (Scanner scanner = new Scanner(System.in)) {
            DecimalFormatSymbols symbol = new DecimalFormatSymbols();
            symbol.setDecimalSeparator('.');

            DecimalFormat format = new DecimalFormat("#.000", symbol);
            
            double fuel = 12.0;
            int hours = scanner.nextInt();
            int distance = scanner.nextInt();
            
            int distanceInHours = hours * distance;
            
            double totalFuelSpent = distanceInHours / fuel;
            
            System.out.println(format.format(totalFuelSpent));
        }
    }
}