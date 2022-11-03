public class Livro
{
    private string Titulo{get;set;}
    private int QtdPaginas{get;set;}
    private int PaginasLidas{get;set;}

    public Livro(string titulo, int paginas)
    {
        this.Titulo = titulo;
        this.QtdPaginas = paginas;
    }
    public void verificarProgresso()
    {
        int paginas = this.QtdPaginas;
        int lidas = this.PaginasLidas;
        int porcentagem = (lidas*100) / paginas;
        Console.WriteLine($"Voce ja leu {porcentagem}% do livro.");
    }
}