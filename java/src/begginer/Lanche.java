package begginer;

import java.text.DecimalFormat;
import java.text.DecimalFormatSymbols;
import java.util.Scanner;

public class Lanche {
    public static void main(String[] args) {
        try(Scanner scanner = new Scanner(System.in)) {
            DecimalFormatSymbols symbol = new DecimalFormatSymbols();
            symbol.setDecimalSeparator('.');

            DecimalFormat format = new DecimalFormat("#.00", symbol);

            double[] products = {4.00, 4.50, 5.00, 2.00, 1.50};
            String line = scanner.nextLine();

            String[] values = line.split(" ");

            int code = Integer.parseInt(values[0]);
            int amount = Integer.parseInt(values[1]);

            Double totalPayable = products[code - 1] * amount;

            System.out.println("Total: R$ " + format.format(totalPayable));
        }
    }
}
