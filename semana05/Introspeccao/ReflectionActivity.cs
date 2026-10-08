using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Pense em uma ocasião em que você defendeu outra pessoa.",
        "Pense em uma ocasião em que você fez algo realmente difícil.",
        "Pense em uma ocasião em que você ajudou alguém necessitado.",
        "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."
    };

    private List<string> _questions = new List<string>
    {
        "Por que essa experiência foi significativa para você?",
        "Você já fez algo assim antes?",
        "Como você começou?",
        "Como você se sentiu quando terminou?",
        "O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?",
        "Qual é a sua coisa favorita sobre essa experiência?",
        "O que você pode aprender com essa experiência que se aplica a outras situações?",
        "O que você aprendeu sobre si mesmo por meio dessa experiência?",
        "Como você pode manter essa experiência em mente no futuro?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base(
            "Atividade de Reflexão",
            "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder que você tem e como pode usá-lo em outros aspectos da sua vida.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Considere o seguinte:");

        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.WriteLine("Quando estiver pronto, pressione Enter.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Agora reflita sobre cada uma das perguntas a seguir.");
        Console.WriteLine();

        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("> " + GetRandomQuestion());
            Console.WriteLine();

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
}