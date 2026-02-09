package Problema_Exercicio7_EngordarEmagrecer;

import java.util.Scanner;

public class Problema_Exercicio7_EngordarEmagrecer {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		System.out.print("Digite o seu peso atual em Kg: ");
		double peso = entrada.nextDouble();
		System.out.println("Emagrecendo 20% você pesaria " + (peso*0.8) + " Kg");
		System.out.println("Engordando 15% você pesaria " + (peso*1.15) + " Kg");
	}
}