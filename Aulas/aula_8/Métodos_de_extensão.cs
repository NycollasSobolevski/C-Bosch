using System;
using System.Collections.Generic;

public static class MyExtensionMethods
{
    public static double Sqrt(this double x)
    {
        return Math.Sqrt(x);
    }
    public static void Print<T>(this T obj)
    {
        Console.WriteLine(obj);
    }
    
    public static List<T> Take<T>(this List<T> list, int N)
    {
        List<T> result = new List<T>();
        for(int i =0; i < N && i < list.Count; i++)
        {
            result.Add(list[i]);
        }
        return result;
    }
    public static List<T> Skip<T>(this List<T> list, int N)
    {
        List<T> result = new List<T>();
        for(int i = N; i < list.Count; i++)
        {
            result.Add(list[i]);
        }
        return result;
    }

    public static List<string> ToStringList<T>(this List<T> list)
    {
        List<string> result = new List<string>();
        for (int i =0; i<list.Count; i++)
        {
            result.Add(list[i]?.ToString() ?? "");
        }
        return result;
    }

    public static string Concat(this List<string> list)
    {
        string result = " ";
        for (int i =0; i < list.Count; i++)
        {
            result+= list[i];
        }
        return result;
    }
}