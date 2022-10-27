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
    int delay = 1000;
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

            Console.WriteLine($"\n\n-------------- 0 - Gerar {Gerando} --------------");
            Console.WriteLine($"\n\n1 - LOJA                      3 - SAIR ");

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
                    bool menuRun = true;
                    while(menuRun)
                    {
                        Console.Clear();
                        Console.WriteLine($"\n\nEscolha uma maquina: \n\n");
                        
                        int indexMaq=1;
                        foreach(var x in maquinas)
                        {
                            Console.WriteLine($"{indexMaq} - {x.Name} LEVEL {x.Level + 1}   ${x.Price}");
                            indexMaq++;
                        }

                        Console.WriteLine($"0 - SAIR DA LOJA");

                        int escolha = (int.Parse(Console.ReadLine()));
                        if (escolha == 0)
                            menuRun = false;
                        else if (escolha > 0 )
                        {
                            escolha--;
                            if (Money < maquinas[escolha].Price)
                                Console.WriteLine($"\n\nDinheiro insuficiente\nFalta ${maquinas[escolha].Price - Money}");
                            else
                            {
                                Money -= maquinas[escolha].Price;
                                maquinas[escolha].Level++;
                                Console.WriteLine($"\n\n{maquinas[escolha].Name} nivel  {maquinas[escolha].Level}");
                            }
                        }
                        else{
                            Console.WriteLine("Insira um valor válido"); 
                        }
                        System.Threading.Thread.Sleep(delay); 
                    }
                break;
            }
        }
    }
}

