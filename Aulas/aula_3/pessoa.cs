using System;

public class Pessoa     //usa como ponteiro 
{
    public Pessoa(string nome, string senha)
    {
        this.Nome = nome;
        this.Senha = senha;
        this.Saldo = 0;
        this.DataNascimento = DateTime.Now;
        this.cpf = 10;
    }

    public string Nome;
    public decimal Saldo { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Senha {get;set;}



    private long cpf;   //campo
    public string CPF   //propriedade
    {
        get
        {
            return cpf.ToString("000.000.000-00");
        }
        set
        {
            cpf = long.Parse(
            value.Replace(".","")
            .Replace("-",""));
        }
    }
}

