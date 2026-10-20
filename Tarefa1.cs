using System;
					
public class Program
{
	public static void Main()
	{
		String nome; //declarando a variável nome
	    String Sobrenome;
		int idade;
		
		
		Console.WriteLine("Insira seu nome"); //Escreva: "insira seu nome"
		nome = Console.ReadLine(); //A variável nome recebe o valor digitado pelo usuário
		
		Console.WriteLine("Insira seu sobrenome");
		Sobrenome = Console.ReadLine();
		
		Console.WriteLine("Insira sua idade");
		idade  = Convert.ToInt16(Console.ReadLine()); // Cpnvert.ToInt16 converte a idade (console.ReadLine()) lê a linha para executar 
		Console.WriteLine("Olá " + nome + " " + Sobrenome + " você possui " + idade  + " anos de idade" );
	}
}