public class Player
{
    public int Id {get;set;}
    public string Nome {get;set;}
    public string Apelido{get;set;}
    public string Nascimento {get;set;}
    public int Numero {get;set;}
    public string Posicao {get;set;}
    public int Qualidade {get;set;}
    public int Cartoes {get;set;}
    public bool Suspensao {get;set;}

    public Player(int id, string nome, string apelido,string nascimento,
    int numero, string posicao, int cartoes, bool suspensao)
    {
        this.Id = id;
        this.Nome = nome;
        this.Apelido = apelido;
        this.Nascimento = nascimento;
        this.Numero = numero;
        this.Posicao = posicao;
        this.Cartoes = cartoes;
        this.Suspensao = suspensao;

        if(cartoes >= 3)
            this.Suspensao = true;
    }

    public void AplicarCartao(int quantidade)
    {
        this.Cartoes += quantidade;
    }

    public void CumprirSuspensao()
    {
        this.Cartoes = 0;
        this.Suspensao = false;
    }

    public void SofrerLesao()
    {
        if(this.Qualidade>0)
        {
            Random r = new Random();
            r.Next(5);
            int lesao = r.Next(100);
            if (lesao < 40)
                this.Qualidade -= 1; 
            else if (lesao < 70)
                this.Qualidade -= 2; 
            else if (lesao <85)
                this.Qualidade -= this.Qualidade*(5/100); 
            else if (lesao < 95)
                this.Qualidade -= this.Qualidade*(10/100); 
            else
                this.Qualidade -= this.Qualidade*(15/100); 

            Console.WriteLine($"A qualidade do jogador está em {this.Qualidade}");
        }
        else
            Console.WriteLine("A qualidade do jogador está em 0");
    }
    public void ExecutarTreinamento()
    {
        if(this.Qualidade>0)
        {
            Random r = new Random();
            r.Next(5);
            int lesao = r.Next(100);
            if (lesao < 40)
                this.Qualidade += 1; 
            else if (lesao < 70)
                this.Qualidade += 2; 
            else if (lesao <85)
                this.Qualidade += 3; 
            else if (lesao < 95)
                this.Qualidade += 4; 
            else
                this.Qualidade += 5; 

            Console.WriteLine($"A qualidade do jogador está em {this.Qualidade}");
        }
        else
            Console.WriteLine("A qualidade do jogador está em 0");
    }
}