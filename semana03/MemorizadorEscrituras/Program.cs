using System;

class Program
{
    static void Main(string[] args)
    {
        // Requisito extra:
        // O programa evita esconder palavras que já estão escondidas.

        Referencia referencia = new Referencia("João", 3, 16);

        Escritura escritura = new Escritura(
            referencia,
            "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito para que todo aquele que nele crê não pereça mas tenha a vida eterna."
        );

        while (!escritura.TodasEscondidas())
        {
            Console.Clear();

            escritura.Exibir();

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar ou digite sair.");

            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "sair")
            {
                return;
            }

            escritura.EsconderPalavras(3);
        }

        Console.Clear();
        escritura.Exibir();

        Console.WriteLine();
        Console.WriteLine("Todas as palavras foram escondidas!");
    }
}