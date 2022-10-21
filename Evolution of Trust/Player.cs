public abstract class Player
{
    public int Moeda {get; protected set;} = 1;

    public abstract bool Decidir();         // Abstract porque ele EXIGE que nas classes filha seja alterado (colocar conteudo)
    public virtual void Recebe(int valor)   // Virtual tem aquele conteudo por padrao, porem permitindo que seja alterado SE QUISER
    {
        this.Moeda += valor;
    }
}


