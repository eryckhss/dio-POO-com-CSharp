namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Ola, meu nome e {Nome}. Sou um professor e ganho {Salario} reais");
        }
    }
}