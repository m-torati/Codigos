package Problema_Exercicio5_Desconto;

import java.util.Scanner;

public class Problema_Exercicio5_Desconto {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		System.out.print("Digite o valor do produto: R$");
		double preco = entrada.nextDouble();
		double precoFINAL = preco * 0.9;
		System.out.println("Valor final com desconto: R$"+ precoFINAL);
		double desconto = preco * 0.1;
		System.out.println("Valor do desconto: R$" + desconto);
	}
}
