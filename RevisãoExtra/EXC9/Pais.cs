public class Pais
{
    public string Code{get;set;}
    public string Name{get;set;}
    public int Pop{get;set;}
    public int Dim{get;set;}
    public List<Pais> Fronteira = new List<Pais>();
    
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


    public string Limitrofe(Pais pais)
    {
        foreach(var x in Fronteira)
        {
            if (x.Code == pais.Code)
                return $"{pais.Name} faz fronteira com {this.Name}";
        }
        return null;
    }

    public string Densidade() => $"Densidade demografica de {this.Pop / this.Dim} habitantes por KM²";

    public List<Pais> VizinhosComum(Pais pais)
    {
        List<Pais> lista = new List<Pais>();
        foreach(var x in pais.Fronteira)
        {
            foreach(var y in this.Fronteira)
            {
                if (x.Code == y.Code)
                {
                    lista.Add(x);
                }
            }
        }
        return lista;
    }

    public bool IsEquals(Pais country) => this.Code == country.Code;
} 