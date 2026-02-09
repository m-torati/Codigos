package Problema_Exercicio6_SalarioEcomissao;
import java.util.Scanner;
public class Problema_Exercicio6_SalarioEcomissao {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		System.out.print("Qual é o seu salário fixo por mês?: ");
		double salario = entrada.nextDouble();
		System.out.print("Quantas vendas você fez neste mês?: ");
		int vendas = entrada.nextInt();
		double[] vetor = new double[vendas];
		double soma = 0;
		for(int i = 0; i<vetor.length; i++) {
			System.out.print("Qual o valor da " + (i+1) + "ª venda: ");
			vetor[i] = entrada.nextDouble();
			soma+=vetor[i];
			while(vetor[i]<=0) {
				System.out.print("Erro. Digite novamente: ");
				vetor[i] = entrada.nextDouble();
			}
		}
		System.out.println("---------------------------");
		System.out.println("Salário fixo: R$ "+salario);
		System.out.println("Comissão: R$ "+(soma*0.04));
		System.out.println("Total: R$ "+(salario+(soma*0.04)));
	}
}