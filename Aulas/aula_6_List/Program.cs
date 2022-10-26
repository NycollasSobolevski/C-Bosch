using System.Collections;

IntList list = new IntList();
list.Add(4);
list.Add(2);
list.Add(1);

foreach(int n in list)
{
    Console.WriteLine(n);
}


public class IntList : IEnumerable
{
    private int[] values = new int[10];
    private int count = 0;

    public int Count => count;
    
    public int this[int index]
    {
        get
        {
            if (index < 0 || index>=count)
                throw new IndexOutOfRangeException();
            return values[index];
        }
        set
        {
            if (index < 0 || index>=count)
                throw new IndexOutOfRangeException();
            values[index] = value;
        }
    }

    public void Add(int num )
    {
        if (count == values.Length)
        {
            int[] newArr = new int[2*values.Length];
            for(int i = 0; i< values.Length; i++)
                newArr[i] = values[i];
            this.values = newArr;
        }

        values[count] = num;
        count++;
    }

    public IEnumerator GetEnumerator()
    {
        IntListInterator it = new IntListInterator(this);
        return it;
    }
}

public class IntListInterator : IEnumerator
{
    private IntList list;
    int index = -1;
    public IntListInterator(IntList list)
    {
        this.list = list;
    }

    public object Current => list[index];

    public bool MoveNext()
    {
        index++;
        return index < list.Count;
    }

    public void Reset() => index = -1;
}