public class Animals
{
    public string Name{get;set;}
    public string Type{get;set;}
    public void Type(string Type)
    {
        if (Type == "cachorro")
            return "cachorro";
        else if (Type == "gato")
            return "gato";
        else if (Type == "peixe")
            return "peixe";
        else
            return "peixe";
    }
}