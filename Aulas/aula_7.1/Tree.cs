public class Tree
{
    public int Direita = 0;
    public int Esquerda = 0;
    public int ValorPrincipal = 0;

    public void Add (int value)
    {
        if (value > ValorPrincipal)
            this.Direita = value;
        else if (value <= ValorPrincipal)
            this.Esquerda = value;
    }
}