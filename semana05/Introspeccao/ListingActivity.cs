using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;


    public ListingActivity() : base(
        "Atividade de Listagem",
        "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.")
    {
        _prompts = new List<string>()
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };

        _items = new List<string>();
    }


    public void Run()
    {
        DisplayStartingMessage();


        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];


        Console.WriteLine();
        Console.WriteLine("Pense sobre a seguinte pergunta:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");


        Console.WriteLine();
        Console.WriteLine("Comece a pensar...");
        ShowCountDown(5);


        Console.WriteLine();
        Console.WriteLine("Liste quantas respostas puder:");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());


        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();


            if (!string.IsNullOrWhiteSpace(item))
            {
                _items.Add(item);
            }
        }


        Console.WriteLine();
        Console.WriteLine($"Você listou {_items.Count} itens.");


        DisplayEndingMessage();
    }
}