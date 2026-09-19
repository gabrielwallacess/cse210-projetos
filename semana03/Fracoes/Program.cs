using System;

class Program
{
    static void Main(string[] args)
    {
        // Testando os construtores
        Fracao f1 = new Fracao();
        Fracao f2 = new Fracao(5);
        Fracao f3 = new Fracao(3, 4);
        Fracao f4 = new Fracao(1, 3);

        Console.WriteLine(f1.ObterFracaoEmTexto());
        Console.WriteLine(f1.ObterFracaoEmDecimal());

        Console.WriteLine(f2.ObterFracaoEmTexto());
        Console.WriteLine(f2.ObterFracaoEmDecimal());

        Console.WriteLine(f3.ObterFracaoEmTexto());
        Console.WriteLine(f3.ObterFracaoEmDecimal());

        Console.WriteLine(f4.ObterFracaoEmTexto());
        Console.WriteLine(f4.ObterFracaoEmDecimal());

        // Testando getters e setters
        Console.WriteLine("\nTestando Getters e Setters");

        f1.SetNumerador(6);
        f1.SetDenominador(7);

        Console.WriteLine($"Numerador: {f1.GetNumerador()}");
        Console.WriteLine($"Denominador: {f1.GetDenominador()}");
        Console.WriteLine($"Fração: {f1.ObterFracaoEmTexto()}");
        Console.WriteLine($"Decimal: {f1.ObterFracaoEmDecimal()}");
    }
}