using System;
using EncapsulamentoNota;

internal class Program
{
    private static void Main(string[] args)
    {
        // Criando alunos
        Estudante aluno1 = new Estudante("Carlos", 8.5);
        Estudante aluno2 = new Estudante("Ana", 5.2);

        // Exibir detalhes básicos
        aluno1.ExibirDetalhes();
        aluno2.ExibirDetalhes();

        Console.WriteLine(); // Linha em branco para separar a saída

        // Exibir informações completas
        aluno1.ExibirInformacoes();
        aluno2.ExibirInformacoes();
    }
}
