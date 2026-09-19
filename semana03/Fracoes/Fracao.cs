using System;

public class Fracao
{
    private int _numerador;
    private int _denominador;

    // Construtor padrão
    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    // Construtor com numerador
    public Fracao(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    // Construtor com numerador e denominador
    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    // Getters
    public int GetNumerador()
    {
        return _numerador;
    }

    public int GetDenominador()
    {
        return _denominador;
    }

    // Setters
    public void SetNumerador(int numerador)
    {
        _numerador = numerador;
    }

    public void SetDenominador(int denominador)
    {
        _denominador = denominador;
    }

    // Retorna a fração em texto
    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }

    // Retorna a fração em decimal
    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
}