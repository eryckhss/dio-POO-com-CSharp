namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Ola, meu nome e {Nome}. Sou aluno nota {Nota}.");
        }
    }
}