public class Rect
{
    public int Altura{get;set;}
    public int Largura{get;set;}
    public int Area{get;set;}

    public Rect(int h, int l)
    {
        this.Largura = l;
        this.Altura = h;
        this.Area = l*h;   
    }
    
    public Rect(){}

    public void Mostrar()
    {
        Console.WriteLine($"Área = {this.Area}");
    }
}