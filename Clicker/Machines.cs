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

    public override float Price => 10 * (Level+0.5f+1);


}