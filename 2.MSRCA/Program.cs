﻿using System;

namespace _2.MSRCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2 - Metodo sem retorno com argumento");

            //Exemplo
            Console.WriteLine("Informe a nota 1");

            string n1Digitada = Console.ReadLine();
            int n1 = Int32.Parse(n1Digitada);

            Console.WriteLine("Informe a nota 2");

            string n2Digitada = Console.ReadLine();
            int n2 = Int32.Parse(n2Digitada);
            CalculaMedia(n1, n2);

            Console.WriteLine();
            Console.WriteLine();

            //Exercicio
            Console.WriteLine("Digite um valor para dar início a contagem");
            string valorDigitado = Console.ReadLine();
            int valor = Int32.Parse(valorDigitado);

            Contador(valor);

            Console.ReadKey();
        }

        public static void CalculaMedia(int n1, int n2)
        {
            double media = (n1 + n2) / 2;

            Console.WriteLine("O média é: " + media);
        }

        public static void Contador(int limite)
        {
            Console.WriteLine("Olá, sou o Metodo sem retorno com argumento");

            for (int contador = 1; contador <= limite; contador++)
            {
                Console.WriteLine(contador);
            }
        }
    }
}
