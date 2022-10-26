World mundo = new World();
mundo.WorldReady();

public class World
{
    Machine01 maquina1 = new Machine01();
    //Machine [] MachineList = new Machine[]

    bool running = true;
    Machine01 maquina = new Machine01();
    public float Money;
    public float Gerando = 1;

    public void WorldReady()
    {
        while(running)
        {
            Console.Clear();
            Console.WriteLine($"Dinheiro = {Money}");
            Console.WriteLine($"{maquina1.Name} level {maquina1.Level}");
            Console.WriteLine($"{maquina1.Name} gera {maquina1.Multiplier}");

            Console.WriteLine($"0 - Gerar {Gerando}");
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
                    Console.WriteLine($"Escolha uma maquina: ");
                    Console.WriteLine($"1 - {maquina1.Name} LEVEL {maquina1.Level + 1}   ${maquina1.Price}");
                    //int EscolhaMaquinas = int.Parse(Console.ReadLine());
                    switch(Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            if (Money < maquina1.Price)
                                Console.WriteLine($"Dinheiro insuficiente\nFalta ${maquina1.Price - Money}");
                            else
                            {
                                Money -= maquina1.Price;
                                maquina1.Level++;
                            }

                        break;
                    }

                break;



            }
        }
    }
}

