using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;
    private Random _random = new Random();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(' ');

        foreach (string palavra in palavras)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public void Exibir()
    {
        Console.WriteLine(_referencia.ObterReferencia());
        Console.WriteLine();

        foreach (Palavra palavra in _palavras)
        {
            Console.Write(palavra.ObterTexto() + " ");
        }

        Console.WriteLine();
    }

    public void EsconderPalavras(int quantidade)
    {
        int escondidas = 0;

        while (escondidas < quantidade)
        {
            int indice = _random.Next(_palavras.Count);

            if (!_palavras[indice].EstaEscondida())
            {
                _palavras[indice].Esconder();
                escondidas++;
            }

            if (TodasEscondidas())
                break;
        }
    }

    public bool TodasEscondidas()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaEscondida())
            {
                return false;
            }
        }

        return true;
    }
}