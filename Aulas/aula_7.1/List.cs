using System;
//################# LIST Generica ####################

public class LinkedList<T>
{
    private LinkedListNode<T> first = null;
    private int count = 0;

    public int Count => count;

    public T this[int index]
    {
        get
        {
            if(first == null)
                throw new IndexOutOfRangeException();

            LinkedListNode<T> atual = first;
            for (int i = 0; i < index; i++)
            {
                if (atual.Next == null)
                    throw new IndexOutOfRangeException();
                
                atual = atual.Next;
            }


            return atual.Value;
        }
        set
        {
            if(first == null)
                throw new IndexOutOfRangeException();

            var atual = first;
            for (int i = 0; i < index; i++)
            {
                if (atual.Next == null)
                    throw new IndexOutOfRangeException();
                
                atual.Value = value;
            }

            

        }
    }

    public void Add(T value)
    {
        if (first == null)
        {
            first = new LinkedListNode<T>();
            first.Value = value;
            count++;
            return;
        }
        var atual = first;
        while(atual.Next != null)
            atual = atual.Next;
        

        atual.Next = new LinkedListNode<T>();
        atual.Next.Value = value;
        count++;
    }
}

public class LinkedListNode<T>
{
    public T Value { get; set; }
    public LinkedListNode<T> Next { get; set; }
}
// #####################################################


