public class Pessoa
{
    public string Nome {get;set;}
    public int Idade {get;set;}

    public Pessoa(string Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }
    public Pessoa(){}

    public void ExibirDados(Pessoa pessoa)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}\nIdade: {pessoa.Idade}");
    }
}
