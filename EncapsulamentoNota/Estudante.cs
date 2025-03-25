using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoNota
{
    public class Estudante
    {
        //Atributos privados (não sei se é necessário - confirmar)
        private string nome;
        private double nota;

        //Propriendade prop Nome 
        public string Nome { get; set; }

        //Propriedade nota já fz a validação com o if 
        public double Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                    nota = value;
                else
                    throw new ArgumentException("A nota deve ser entre 0 e 10.");
            }
        }

        //Construtor que inicializa os atributos 
        public Estudante(string Nome, double Nota)
        {
            //Usam a propriedade Nome e Nota (checar o pq disso)
            this.Nome = Nome;
            this.Nota = Nota;
        }

        //Metodo de verificar aprovação com bool V ou F 
        public bool EstaAprovado()
        {
            return Nota >= 6;
        }

        //CW para exibir as infos do aluno 
        public void ExibirDetalhes()
        {
            System.Console.WriteLine($"Nome: {Nome} \tNota: {Nota}");

        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {Nome} \tNota: {Nota} \tStatus: {(EstaAprovado() ? "Aprovado" : "Reprovado")}");
        }

    }
}