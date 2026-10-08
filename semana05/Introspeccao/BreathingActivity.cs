using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Atividade de Respiração",
            "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Inspire... ");
            ShowCountDown(4);

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("Expire... ");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}