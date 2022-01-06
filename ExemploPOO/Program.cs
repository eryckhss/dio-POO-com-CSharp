using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(String[] args)
        {
            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 13));
            System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 13, 3));



            // Aluno p1 = new Aluno();

            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = "1234567";
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();

            // p2.Nome = "Mateus";
            // p2.Idade = 20;
            // p2.Documento = "1234567";
            // p2.Salario = 2000;
            // p2.Apresentar();


            // Valores validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Area: {r.ObterArea()}");

            // // Valores invalidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Area: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}
