public class Individuo
{
    public string CPF{get; private set;}
    List<DespesaMes> despesa = new List<DespesaMes> {};
    public Individuo(string cpf)
    {
        this.CPF = cpf;
        this.despesa = new List<DespesaMes>();
    }

    public void addDespesa(DespesaMes dsp) => despesa.Add(dsp);


    public float totalizaMes (int mes)
    {
        float valor=0;
        foreach(var x in despesa)
        {
            if(x.Mes == mes)
            {
                valor += x.Valor;
            }
        }
        return valor;
    }
}