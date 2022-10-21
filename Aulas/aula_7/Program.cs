using System;

World world = new World();

world.GeratePlayers(100, 100, 100, 200);



public class World
{
    public int MoedasGeradas = 0;
    
    public Player[] Players = new Player[500];
    private int index { get; set; }
    public int Total = 500;             // Total de uma moeda por pessoa
    public int Round = 0;
    public int Falidos{get;set;}
    public void Operation(Player player1, Player player2)
    {
        

        if (player1.Moedas>0 && player1.Moedas>0)
        {
            if (player1.Decide() && player2.Decide())
            {
                player1.Moedas++;
                player2.Moedas++;
                MoedasGeradas += 2;
                
            }
            else if (player1.Decide() && player2.Decide() == false)
            {
                player1.Moedas -= 1;
                player2.Moedas += 3;
                MoedasGeradas += 3;
            }
            else if (player1.Decide() == false && player2.Decide())
            {
                player1.Moedas += 3;
                player2.Moedas -= 1;
                MoedasGeradas += 3;
            }
        }
        Total += MoedasGeradas;
        Round++;
    }
    private void AddPlayer(Player player)                                                       //Função que pega um tipo de player para adicionar em uma lista
    {
        this.Players[this.index] = player;
        this.index++;
    }
    public void GeratePlayers(int cooperadores, int egoistas, int remorsos, int copycats)       // Função que escolhe a quantidade de cada tipo de player voce quer 
    {
        if (cooperadores + egoistas + remorsos + copycats != this.Players.Length)
            throw new Exception();
        for (int i = 0; i < cooperadores; i++)          // Adiciona os COPERADORES
            this.AddPlayer(new Cooperador());
        for (int i = 0; i < egoistas; i++)              // Adiciona os EGOISTAS
            this.AddPlayer(new Egoista());
        for (int i = 0; i < remorsos; i++)              // Adiciona os REMORSOS
            this.AddPlayer(new Remorse());
        for (int i = 0; i < copycats; i++)              // Adiciona os COPYCATS
            this.AddPlayer(new CopyCat());
    }
}


public abstract class Player
{
    public int Moedas { get; set; } = 1;
    public abstract bool Decide();
    public abstract void Recebe(int moedas);
}


public class Cooperador : Player
{

    public override bool Decide() => true;


    public override void Recebe(int moedas)
    {
        
    }
}

public class Egoista : Player
{

    public override bool Decide() => false;

    public override void Recebe(int moedas)
    {
        
    }
}

public class Remorse : Player
{
    public bool remorse = false;
    public override bool Decide() => !remorse;

    public override void Recebe(int moedas)
    {
        if (moedas == 0)
        {
             remorse = true;
        }
    }
}
public class CopyCat : Player
{
    public bool copy = true;
    public override bool Decide() => copy;

    public override void Recebe(int moedas)
    {
        if (moedas == 0)
        {
             copy = false;
        }
        else if (moedas > 0)
        {
             copy = true;
        }
    }
}
