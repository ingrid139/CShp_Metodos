using System;

namespace _1.MSRSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 1 - Metodo sem retorno sem argumento");

            //Exemplo
            Alisa();

            //Exercicio
            Contador();

            Console.ReadKey();
        }

        public static void Alisa()
        {
            Console.WriteLine("Pegar prancha");
            Console.WriteLine("Ligar tomada");
            Console.WriteLine("Aguardar esquentar");
            Console.WriteLine("4 - Separar a mecha a ser alisada");
            Console.WriteLine("5 - Passar a prancha na mecha separada");
            Console.WriteLine("Repetir 4 e 5 até que todo o cabelo esteja liso");
        }

        public static void Contador()
        {
            Console.WriteLine("Olá, sou o Metodo sem retorno sem argumento");

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }
        }
    }
}
