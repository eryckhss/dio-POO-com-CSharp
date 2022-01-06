﻿using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(String[] args)
        {
            // Valores validos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);
            System.Console.WriteLine($"Area: {r.ObterArea()}");

            // Valores invalidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 0);
            System.Console.WriteLine($"Area: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}
