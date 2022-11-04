



Livro LivroFavorito = new Livro("O Pequeno Príncipe",98);
Console.WriteLine($"O livro {LivroFavorito.getTitulo()} tem {LivroFavorito.getQtdPaginas()} páginas.");
LivroFavorito.setPaginasLidas(20);
LivroFavorito.verificarProgresso();
LivroFavorito.setPaginasLidas(50);
LivroFavorito.verificarProgresso();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira o nome do {i+1}° livro");
    string Name = Console.ReadLine();
    Console.WriteLine($"Insira a quantidade de paginas de {Name}:");
    string paginas = Console.ReadLine();

}