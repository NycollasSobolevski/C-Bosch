public abstract class Machine
{
    public Machine(string name)
    {
        this.Name = name;
        this.Level = 0;
    }

    public string Name{get;set;}
    public float Level {get;set;}
    public abstract float Multiplier { get; }
    public abstract float Price {get;}
}


public class Machine01 : Machine
{
    public Machine01() : base("Pulverizador") { }

    public override float Multiplier => 2 * Level;

    public override float Price => (10 * (Level+0.5f+1))*3;
    
}

public class Machine02 : Machine
{
    public Machine02() : base("Boost") { }

    public override float Multiplier => 2.5f * Level;

    public override float Price => (15 * (Level+0.5f+1))*3;

}
public class Machine03 : Machine
{
    public Machine03() : base("Gerador") { }

    public override float Multiplier => 3.85f * Level;

    public override float Price => (50 * (Level+0.5f+1))*3;

}