using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random random = new Random();

        List<string> prompts = new List<string>
        {
            "Quem foi a pessoa mais interessante com quem interagi hoje?",
            "Qual foi a melhor parte do meu dia?",
            "Como vi a mão do Senhor em minha vida hoje?",
            "Qual foi a emoção mais forte que senti hoje?",
            "Se eu pudesse fazer uma coisa hoje, o que seria?",
            "O que aprendi hoje que posso usar amanhã?",
            "Por que sou grato hoje?"
        };

        int opcao = 0;

        Console.WriteLine("Bem-vindo ao Diário!");

        while (opcao != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Escrever novo registro");
            Console.WriteLine("2 - Exibir diário");
            Console.WriteLine("3 - Salvar diário");
            Console.WriteLine("4 - Carregar diário");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out opcao))
            {
                switch (opcao)
                {
                    case 1:

                        string prompt = prompts[random.Next(prompts.Count)];

                        Console.WriteLine();
                        Console.WriteLine(prompt);
                        Console.Write("> ");

                        string resposta = Console.ReadLine();

                        Entry entry = new Entry();

                        entry._date = DateTime.Now.ToShortDateString();
                        entry._promptText = prompt;
                        entry._entryText = resposta;

                        journal.AddEntry(entry);

                        Console.WriteLine("Registro adicionado com sucesso!");

                        break;

                    case 2:

                        journal.DisplayAll();

                        break;

                    case 3:

                        Console.Write("Nome do arquivo: ");
                        string salvar = Console.ReadLine();

                        journal.SaveToFile(salvar);

                        break;

                    case 4:

                        Console.Write("Nome do arquivo: ");
                        string carregar = Console.ReadLine();

                        journal.LoadFromFile(carregar);

                        break;

                    case 5:

                        Console.WriteLine("Até logo!");

                        break;

                    default:

                        Console.WriteLine("Opção inválida.");

                        break;
                }
            }
            else
            {
                Console.WriteLine("Digite um número válido.");
            }
        }
    }
}