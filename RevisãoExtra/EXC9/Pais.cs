public class Pais
{
    public string Code{get;set;}
    public string Name{get;set;}
    public int Pop{get;set;}
    public int Dim{get;set;}
    List<Pais> Fronteira = new List<Pais>();
    
    public Pais(string codeISO, string nome, int dimensao, int populacao)
    {
        this.Code = codeISO;
        this.Name = nome;
        this.Dim = dimensao;
        this.Pop = populacao;
    }

    public void addFronteiras(Pais pais)
    {
        this.Fronteira.Add(pais);
    }


    public void Limitrofe(Pais pais)
    {
        foreach(var x in Fronteira)
        {
            if (x.Code == pais.Code)
                return $"{pais.Name} faz fronteira com {this.Name}";
        }
    }

    public void Densidade() => this.Pop / this.Dim;

    public void VizinhosComum(Pais pais)
    {
        List<Pais> lista = new List<Pais>();
        foreach(var x in pais.Fronteira)
        {
            foreach(var y in this.Fronteira)
            {
                if (x == y )
                {
                    lista.Add(x);
                }
            }
        }
        return lista;
    }

    public bool IsEquals(Pais country) => this.Code == country.Code;
} 