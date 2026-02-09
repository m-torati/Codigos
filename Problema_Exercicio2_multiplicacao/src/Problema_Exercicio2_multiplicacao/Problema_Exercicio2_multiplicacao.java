package Problema_Exercicio2_multiplicacao;
import java.util.Scanner;
public class Problema_Exercicio2_multiplicacao {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		double[] vetor = new double[3];
		for(int i = 0; i<3; i++) {
			System.out.printf("Digite o " + (i+1) + "º número: ");
			vetor[i] = entrada.nextDouble();
		}
		double resultado= 1;
		for(int i = 0; i<3; i++) resultado*=vetor[i];
		
		System.out.println("Resultado: " + resultado);
	}
}
