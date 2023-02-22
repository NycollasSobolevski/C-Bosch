public class Lista
{
    public int[] lista = new int[10];
    private int index { get; set;} = 0;


    public void Add(int i)
    {
        lista[index] = i;
        index++;
    }
}
public class ListaGenerica<T>
{
    public T[] lista = new T[10];
    private int index { get; set;} = 0;
    public void Add(T item)
    {
        lista[index] = item;
        index++;
    }
}

