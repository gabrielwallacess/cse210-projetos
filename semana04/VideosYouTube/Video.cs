public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracao;

    private List<Comentario> _comentarios = new List<Comentario>();


    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
    }


    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }


    public int QuantidadeComentarios()
    {
        return _comentarios.Count;
    }


    public void ExibirVideo()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracao} segundos");
        Console.WriteLine($"Comentários: {QuantidadeComentarios()}");
        Console.WriteLine();

        Console.WriteLine("Lista de comentários:");

        foreach (Comentario comentario in _comentarios)
        {
            Console.WriteLine(comentario.MostrarComentario());
        }

        Console.WriteLine("--------------------------------");
        Console.WriteLine();
    }
}