package begginer;

import java.text.DecimalFormat;
import java.text.DecimalFormatSymbols;
import java.util.Scanner;

public class Media3 {
    public static void main(String[] args) {
        try(Scanner scanner = new Scanner(System.in)) {
            DecimalFormatSymbols symbol = new DecimalFormatSymbols();
            symbol.setDecimalSeparator('.');

            DecimalFormat format = new DecimalFormat("#.0", symbol);

            String line = scanner.nextLine();

            String[] values = line.split(" ");

            double[] grade = convertToDouble(values);

            double simpleAvarage = avarageCalc(grade);

            System.out.println("Media: " + format.format(simpleAvarage));

            if(simpleAvarage >= 7.0) {
                System.out.println("Aluno aprovado.");
                return;
            }

            if(simpleAvarage < 5.0) {
                System.out.println("Aluno reprovado.");
                return;
            }

            System.out.println("Aluno em exame.");

            double finalGrade = scanner.nextDouble();

            double finalAvarage = finalAvarageCalc(simpleAvarage, finalGrade);

            System.out.println("Nota do exame: " + format.format(finalGrade));

            if(finalAvarage >= 5.0) {
                System.out.println("Aluno aprovado.");
                System.out.println("Media final: " + format.format(finalAvarage));
                return;
            }

            System.out.println("Aluno reprovado.");
            System.out.println("Media final: " + format.format(finalAvarage));
        }
    }

    public static double[] convertToDouble(String[] values) {
        double[] valuesConverted = new double[values.length];

        for(int i = 0; i < values.length; i++) {
            valuesConverted[i] = Double.parseDouble(values[i]);
        }

        return valuesConverted;
    }

    public static double avarageCalc(double[] grade) {
        double totalValue = 0;
    
        totalValue += grade[0] * 2;
        totalValue += grade[1] * 3;
        totalValue += grade[2] * 4;
        totalValue += grade[3] * 1;

        double avarage = totalValue / 10;

        return avarage;
    }

    public static double finalAvarageCalc(double simpleAvarage, double finalGrade) {
        double finalAvarage = (simpleAvarage + finalGrade) / 2;
        return finalAvarage;
    }
}
