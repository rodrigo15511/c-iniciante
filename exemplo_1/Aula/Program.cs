﻿using System;
namespace Exemplo
{
    internal class Program
    {
        static void teste()
        {
            int idade = 25;
            double saldo = 10.50;
            string nome = "Maria Conceição";

            Console.WriteLine("Olá " + nome + ",sua idade é" + idade);
            // Ou
            Console.WriteLine("{0} tem {1} anos e tem um saldo igual {2:F2}", nome, idade, saldo);
            //  Ou Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo {saldo}");
        }
    }
}