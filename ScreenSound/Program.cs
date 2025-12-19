Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("Maria");

Episodio ep2 = new(1, "Técnicas de aprendizagem", 45);
ep2.AdicionarConvidados("Daniel");
ep2.AdicionarConvidados("Guilherme");

Podcast podcast = new("Técnicas faladas", "Vinícius");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();