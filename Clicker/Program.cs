World mundo = new World();
mundo.WorldReady();

public class World
{
    Machine01 maquina1 = new Machine01();
    Machine02 maquina2 = new Machine02();
    Machine03 maquina3 = new Machine03();

    List<Machine> maquinas = new List<Machine>();
    

    bool running = true;
    public float Money;
    public float Gerando = 1;
    int delay = 1500;
    public void WorldReady()
    {
        maquinas.Add(maquina1);
        maquinas.Add(maquina2);
        maquinas.Add(maquina3);
        
        while(running)
        {
            Console.Clear();
            Console.WriteLine($"Dinheiro = {Money}");
            foreach(var x in maquinas)
            {
                Console.WriteLine($"{x.Name} gera {x.Multiplier}");
            }

            Console.WriteLine($"\n\n0 - Gerar {Gerando}");
            Console.WriteLine($"1 - Menu ");
            Console.WriteLine($"3 - SAIR ");

            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.D0:
                    Gerando = 1 + maquina1.Multiplier;
                    Money += Gerando;
                break;
                
                case ConsoleKey.D3:
                    running = false;
                break;

                case ConsoleKey.D1:
                    Console.WriteLine($"\n\nEscolha uma maquina: \n\n");
                    
                    int indexMaq=1;
                    foreach(var x in maquinas)
                    {
                        Console.WriteLine($"{indexMaq} - {x.Name} LEVEL {x.Level + 1}   ${x.Price}");
                        indexMaq++;
                    }

                    Console.WriteLine($"0 - SAIR do menu");

                    int escolha = (int.Parse(Console.ReadLine())-1);

                    if (Money < maquinas[escolha].Price)
                        Console.WriteLine($"\n\nDinheiro insuficiente\nFalta ${maquinas[escolha].Price - Money}");
                    else
                    {
                        Money -= maquinas[escolha].Price;
                        maquinas[escolha].Level++;
                        Console.WriteLine($"\n\n{maquinas[escolha].Name} nivel  {maquinas[escolha].Level}");

                    }
                    System.Threading.Thread.Sleep(delay); 
                break;
            }
        }
    }
}

