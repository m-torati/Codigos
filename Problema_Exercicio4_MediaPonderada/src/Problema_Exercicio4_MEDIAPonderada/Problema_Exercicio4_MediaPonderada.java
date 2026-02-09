package Problema_Exercicio4_MEDIAPonderada;

import java.util.Scanner;

public class Problema_Exercicio4_MediaPonderada {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		double[] vetor = new double[2];
		for(int i = 0; i<2; i++)
		{
			System.out.print("Digite a " + (i+1) + "ª nota: ");
			vetor[i] = entrada.nextDouble();
			while(vetor[i]<0)
			{
				System.out.print("Digite uma nota válida: ");
				vetor[i] = entrada.nextDouble();
			}
		}
		double media=0;
		for (int i = 0; i<2; i++) {
			media = ((vetor[0] * 2) + (vetor[1] * 3)) / 5;
		}
		System.out.println("A média do aluno é de " + media + " pontos");
	}
}
