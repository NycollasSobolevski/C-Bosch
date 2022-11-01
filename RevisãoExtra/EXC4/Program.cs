// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

World world = new World();
world.Rodando();
public class World
{
    public void Rodando()
    {
        List<Player> time = new List<Player>();
        for(int i = 0; i<2; i++)
        {
            Console.Clear();
            Console.WriteLine($"Insira o Id do {i+1}° jogador: ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine($"Insira o nome do {i+1}° jogador: ");
            string Nome = Console.ReadLine();
            Console.WriteLine($"Insira o apelido de {Nome}: ");
            string Apelido = Console.ReadLine();
            Console.WriteLine($"Insira o Nascimento de {Nome}: ");
            string Nascimento = Console.ReadLine();
            Console.WriteLine($"Insira o numero de {Nome}: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Insira a posição de {Nome}: ");
            string Posicao = Console.ReadLine();
            // Console.WriteLine($"Insira a qualidade de {Nome}: ");
            // int Qualidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Quantos cartoes {Nome} tem: ");
            int Cartoes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cartão vermelho ou punição: (true ou false)");
            bool suspensao = bool.Parse(Console.ReadLine());

            Player jogador = new Player(Id,Nome,Apelido,Nascimento,Numero,Posicao,Cartoes,suspensao);
            time.Add(jogador);

        }
        foreach(var x in time)
        {
            string condicao = "";
            if(x.Suspensao)
                condicao = "SUSPENSO";
            else
                condicao = "Tá ON";
            Console.WriteLine($"{x.Posicao}: {x.Numero} - {x.Nome} ({x.Apelido}) - {x.Nascimento} CONDIÇÃO: {condicao}");
        }
    }
}