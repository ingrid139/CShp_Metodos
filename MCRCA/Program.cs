using System;

namespace MCRCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3 - Metodo com retorno sem argumento");

            //Exemplo
            Notas notas = BuscaNotas();
            string aprovacao = CalculaMedia(notas.n1, notas.n2);

            Console.WriteLine("Media: " + aprovacao);

            Console.WriteLine();
            Console.WriteLine();

            //Exercicio
            int valor = BuscaLimite();

            Contador(valor);

            Console.ReadKey();
        }

        public static Notas BuscaNotas()
        {
            Notas notas = new Notas();

            Console.WriteLine("Informe a nota 1");

            string n1Digitada = Console.ReadLine();
            notas.n1 = Int32.Parse(n1Digitada);

            Console.WriteLine("Informe a nota 2");

            string n2Digitada = Console.ReadLine();
            notas.n2 = Int32.Parse(n2Digitada);

            return notas;
        }

        public static int BuscaLimite()
        {
            Console.WriteLine("Olá, sou o Metodo com retorno sem argumento");

            Console.WriteLine("Digite um valor para dar início a contagem");
            string valorDigitado = Console.ReadLine();
            return ConvertToInt(valorDigitado);
        }

        public static int ConvertToInt(string valor)
        {
            Console.WriteLine("Olá, sou o Metodo com retorno com argumento");

            return Int32.Parse(valor);
        }

        public static string CalculaMedia(int n1, int n2)
        {
            Console.WriteLine("Olá, sou o Metodo com retorno sem argumento");
            
            double media = (n1 + n2) / 2;
            Console.WriteLine("O média é: " + media);

            string aprovacao;
            if (media >= 7)
            {
                aprovacao = "aprovada";
            }
            else
            {
                aprovacao = "reprovada";
            }

            return aprovacao;
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

    public class Notas
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
    }
}
