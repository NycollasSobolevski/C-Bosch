// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

World world = new World();
world.Rodando();

public class World
{
    List<Animals> animais = new List<Animals>{};
    public void Rodando()
    {
        int dog = 0;
        int cat = 0;
        int fish = 0;

        for(int i = 0; i<5 ; i++)
        {
            Console.WriteLine($"Insira o nome do {i+1}° animal");
            string name = Console.ReadLine();
            Console.WriteLine($"Insira o tipo do {i+1}° animal");
            string type = Console.ReadLine();

            Animals animal = new Animals(name,type);
            animais.Add(animal);
            
            if (type == "cachorro")
                dog++;
            else if (type == "gato")
                cat++;
            else
                fish++;
        }
        Console.WriteLine($"Cachorros: {dog}");
        Console.WriteLine($"Gatos: {cat}");
        Console.WriteLine($"Peixes: {fish}");
    }
}