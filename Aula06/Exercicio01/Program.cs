﻿using System;

/*1. A tabela de aliquota do IRRF foi alterada.
namespace Exercicio01
{
    class Program
    {
        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";

        static void Main(string[] args)
        {
            //string put = "1500";

            var put = Console.ReadLine();

            if (!double.TryParse(put, out double entrada))
            {
                Console.WriteLine("Entrada invalida");
                Console.ReadKey();
            }

            else if (entrada >= 0 || entrada <= 4145)
            {
                Console.WriteLine("Isento");
            }

            else if (entrada > 4145 || entrada <= 5678.34)
            {
                Console.WriteLine($"Valor a pagar: {entrada * 1.2}");
            }

            else if (entrada >= 5678.35 || entrada <= 7838.21)
            {
                Console.WriteLine($"Valor a pagar: {entrada * 1.25}");
            }

            else if (entrada >= 7838.22)
            {
                Console.WriteLine($"Valor a pagar: {entrada * 1.275}");
            }

           Console.ReadKey();




        }
    }
}