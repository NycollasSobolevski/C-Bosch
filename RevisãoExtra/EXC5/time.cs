public class Time
{
    public string Nome{get;set;}
    public string Apelido{get;set;}
    public string Fundacao{get;set;}
    public List<Player> Plantel {get;set;}
    public List<Player> Relacionados{get;set;}

    public Time(string nome, string apelido, string fundacao, List<Player> plantel)
    {
        this.Nome = nome;
        this.Apelido = apelido;
        this.Fundacao = fundacao;
        this.Plantel = plantel;
    }
    public void RelacionarJogadores(List<Player> plantel)
    {
        this.Plantel = plantel;
        List<Player> plantel2 = Plantel.OrderByDescending(x => x.Qualidade).ToList();
        List<Player> relacionados = new List<Player>();
        foreach(var x in plantel2)
        {
            if (relacionados.Count() < 18)
                relacionados.Add(x);
        }
        this.Relacionados = relacionados;
    }
}