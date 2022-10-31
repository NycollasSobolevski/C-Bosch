var coll = "LAB_PR_COV.csv"
    .Open()
    .Skip(1)
    .Take(1000)
    .ToList();


var contains = "ola mundo".Contains("mundo");

foreach(var x in coll)
{
    Console.WriteLine(x);
}

public static class MyExtensionMethods
{
    public static IEnumerable<T> Skip<T>(this IEnumerable<T> coll, int n)
    {
        var it = coll.GetEnumerator();
        for (int i =0;  i<n && it.MoveNext(); i++);
        while(it.MoveNext())
            yield return it.Current;
    }

    public static IEnumerable<T> Take<T>(this IEnumerable<T> coll, int n)
    {
        var it = coll.GetEnumerator();
        for (int i =0;  i<n && it.MoveNext(); i++);
            yield return it.Current;
    }

    public static List<T> ToList<T>(this IEnumerable<T> coll)
    {
        List<T> list = new List<T>();
        
        var it  = coll.GetEnumerator();
        while(it.MoveNext())
            list.Add(it.Current);
        
        return list;
    }

    public static IEnumerable<T> Append<T>(this IEnumerable<T> coll, T item)
    {
        var it = coll.GetEnumerator();
        while(it.MoveNext())
            yield return it.Current;
        
        yield return item;
    }

    public static IEnumerable<T> LastOrDefault<T>(this IEnumerable<T> coll)
    {
        int count  = 0;
        var it = coll.GetEnumerator();
        while(it.MoveNext())
            count++;
        if (count == 0)
            yield return default(T);
        else yield return it.Current;
    }

    public static int Count<T>(this IEnumerable<T> coll)
    {
        int count = 0;
        var it = coll.GetEnumerator();

        while(it.MoveNext())
            count++;
        
        return count;
    }

    public static IEnumerable<T> Prepend<T>(this IEnumerable<T> coll, T item)
    {
        yield return item;  

        var it = coll.GetEnumerator();
        while(it.MoveNext())
            yield return it.Current;
        
    }

    public static T FirstOrDefault<T>(this IEnumerable<T> coll)
    {
        var it = coll.GetEnumerator();
        
        if (it.MoveNext())
            return it.Current;
        else return default(T);
    }
    
    public static T[] ToArray<T>(this IEnumerable<T> coll)
    {
        int cont = 0;

        T[] array = new T[coll.Count()];
        foreach(var x in coll)
        {
            array[cont] = x;
            cont++;
        }
        return array;
    }

    public static IEnumerable<string> Open(this string file)
    {
    var stream = new StreamReader(file);
 
    while(!stream.EndOfStream)
    {
        var line = stream.ReadLine();
        yield return line;
    }
    stream.Close();
    }

    public static IEnumerable<string[]> Split(this IEnumerable<string> coll)
    {
        
    }
}
//================================================================================================

