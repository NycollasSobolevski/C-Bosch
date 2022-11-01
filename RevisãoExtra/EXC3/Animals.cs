public class Animals
{
    private string Name{get;set;}
    private string Type{get;set;}

    public Animals(string Nome, string Type)
    {
        this.Name = Nome;
        if(Type != "cachorro" && Type != "peixe" && Type != "gato" )
            this.Type = "peixe";
        else
            this.Type = Type;
    }

    public Animals(){}

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {this.Name}\nTipo: {this.Type}");
    }
}