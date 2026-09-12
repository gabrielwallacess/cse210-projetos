using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Data: {_date}");
        Console.WriteLine($"Pergunta: {_promptText}");
        Console.WriteLine($"Resposta: {_entryText}");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}
