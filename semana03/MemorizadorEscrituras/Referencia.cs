public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _versiculoFinal;

    // Um versículo
    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _versiculoFinal = versiculo;
    }

    // Intervalo de versículos
    public Referencia(string livro, int capitulo, int versiculo, int versiculoFinal)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _versiculoFinal = versiculoFinal;
    }

    public string ObterReferencia()
    {
        if (_versiculo == _versiculoFinal)
        {
            return $"{_livro} {_capitulo}:{_versiculo}";
        }

        return $"{_livro} {_capitulo}:{_versiculo}-{_versiculoFinal}";
    }
}