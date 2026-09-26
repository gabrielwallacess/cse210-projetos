List<Video> videos = new List<Video>();


// Vídeo 1
Video video1 = new Video(
    "Aprendendo C# do Zero",
    "Gabriel Wallace",
    600
);

video1.AdicionarComentario(
    new Comentario("Maria", "Muito bom esse conteúdo!")
);

video1.AdicionarComentario(
    new Comentario("João", "Aprendi bastante.")
);

video1.AdicionarComentario(
    new Comentario("Ana", "Obrigado pela explicação.")
);


videos.Add(video1);


// Vídeo 2
Video video2 = new Video(
    "Introdução à Programação Orientada a Objetos",
    "Curso Dev",
    900
);

video2.AdicionarComentario(
    new Comentario("Pedro", "POO ficou muito mais fácil.")
);

video2.AdicionarComentario(
    new Comentario("Lucas", "Excelente aula.")
);

video2.AdicionarComentario(
    new Comentario("Carla", "Gostei dos exemplos.")
);

videos.Add(video2);


// Vídeo 3
Video video3 = new Video(
    "Como criar Classes em C#",
    "Programador C#",
    720
);

video3.AdicionarComentario(
    new Comentario("Fernanda", "Muito bem explicado.")
);

video3.AdicionarComentario(
    new Comentario("Rafael", "Ajudou bastante.")
);

video3.AdicionarComentario(
    new Comentario("Bruno", "Esperando a próxima aula.")
);

video3.AdicionarComentario(
    new Comentario("Julia", "Conteúdo excelente.")
);

videos.Add(video3);


// Exibir todos os vídeos

foreach (Video video in videos)
{
    video.ExibirVideo();
}