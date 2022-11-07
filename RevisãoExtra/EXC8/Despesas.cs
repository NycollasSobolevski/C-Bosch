public class DespesaMes
{
    public int Mes{get; private set;}           // mes da despesa
    public float Valor {get; private set;}      // valor da despesa

    public DespesaMes(int mes, float valor)
    {
        this.Mes = mes;
        this.Valor = valor;
    }
}


public class DespesaDia : DespesaMes
{
    public int Dia {get;private set;}          // Despesas do dia
    public DespesaDia(int dia, int mes, float valor) : base(mes, valor)
    {
        this.Dia = dia;
    }
    public int GetDia()
    {
        return this.Dia;
    }
}

