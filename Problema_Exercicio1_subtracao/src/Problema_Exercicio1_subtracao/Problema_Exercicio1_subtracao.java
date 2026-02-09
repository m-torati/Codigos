package Problema_Exercicio1_subtracao;
import java.util.Scanner;

public interface Problema_Exercicio1_subtracao {
	public static void main(String[] args) {
	Scanner read = new Scanner(System.in);

	System.out.print("Digite um número real: ");
	double numero1 = read.nextDouble();
	System.out.print("Digite outro número real: ");
	double numero2 = read.nextDouble();

	double resultado = numero1 - numero2;

	System.out.println("Resultado: " + resultado);
	}
}
