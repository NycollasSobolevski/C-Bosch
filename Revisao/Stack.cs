public class Stack<T>
{
    private T[] list = new T[10];
    private int topo {get; set;} = -1;
    public Stack(int tamanho)
    {
        this.list = new T[tamanho];
    }

    public void Push(T item)
    {
        topo++;
        list[topo] = item;
    }
    public void Pop()
    {
        list[topo] = default(T);
        topo--;
    }
    public bool IsEmpty()
    {
        return topo < 0;
    }
    public int Size()
    {
        return topo+1;
    }
    public void Clear(){
        for(int i = 0; i<list.Count(); i++)
            list[i] = default(T);
        topo = -1;
    }
    public override string ToString()
    {
        string resultado = "";
        for (int i = topo; i >= 0; i--)
        {
            resultado += $"{i} - [{list[i]}]\n";
        }
        return resultado;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}