public abstract class Set
{
    public abstract bool IsIn(Set set);
    
}


public class EmptySet : Set{
    public override bool IsIn(Set set)
    {
        return false;
    }
    public override bool Equals(object obj)
    {
        return obj is EmptySet;
    }
}

public class PairSet : Set
{
    public Set A {get;set;}
    public Set B {get;set;}

    public override bool IsIn(Set set)
    {
        return A.Equals(set) || B.Equals(set);
    }

    public override bool Equals(object obj)
    {
        if (obj is PairSet pair)
        {
            return (pair.A.Equals(this.A) && pair.B.Equals(this.B))
                ||(pair.A.Equals(this.B) && pair.B.Equals(this.A))
                ||(pair.A.Equals(this.B) && (pair.B.Equals(this.A) || pair.A.Equals(this.B)));
        }
        return false;
    }
}


public class UnionSet : Set
{
    public Set A{get;set;}
    public Set B{get;set;}
    public override bool IsIn(Set set)
    {
        return A.IsIn(set) || B.IsIn(set);
    }
}