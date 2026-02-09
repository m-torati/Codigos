package Problema_Exercicio3_divisao;
import java.util.Scanner;
public class Problema_Exercicio3_DIVISAO {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		System.out.println("Se necessário, utilize a vírgula");
		System.out.print("Digite o primeiro número: ");
		double n1 = entrada.nextDouble();
		System.out.print("Digite o segundo número: ");
		double n2 = entrada.nextDouble();
		while(n2==0)
		{
			System.out.print("Digite novamente: ");
			n2 = entrada.nextDouble();
		}
		double resultado = n1 / n2;
		System.out.println("Resultado: " + resultado);
	}
}
