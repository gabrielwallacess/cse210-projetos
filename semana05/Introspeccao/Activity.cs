using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Começando {_name}.");
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("Quanto tempo, em segundos, você gostaria de fazer esta atividade? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare-se...");
        ShowSpinner(5);
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Bom trabalho!");

        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"Você concluiu a atividade {_name} por {_duration} segundos.");

        ShowSpinner(3);
    }


    public int GetDuration()
    {
        return _duration;
    }


    public void ShowSpinner(int seconds)
    {
        string[] animation = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animation[i]);

            Thread.Sleep(500);

            Console.Write("\b \b");

            i++;

            if (i >= animation.Length)
            {
                i = 0;
            }
        }
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }
}