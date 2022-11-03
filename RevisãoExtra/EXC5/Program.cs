World world = new World();
world.Rodando();
public class World
{
    List<Time> ListaTimes = new List<Time>();
    public void Rodando()
    {
        for(int i = 0; i < 2;i++)
        {

            List<Player> lista_players = new List<Player>();
            for(int j = 0; j<23; j++)
            {
                Console.Clear();
                Console.WriteLine($"Insira o Id do {j+1}° jogador: ");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira o nome do {j+1}° jogador: ");
                string Nome = Console.ReadLine();
                Console.WriteLine($"Insira o apelido de {Nome}: ");
                string Apelido = Console.ReadLine();
                Console.WriteLine($"Insira o Nascimento de {Nome}: ");
                string Nascimento = Console.ReadLine();
                Console.WriteLine($"Insira o numero de {Nome}: ");
                int Numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira a posição de {Nome}: ");
                string Posicao = Console.ReadLine();
                Console.WriteLine($"Insira a qualidade de {Nome}: ");
                int Qualidade = int.Parse(Console.ReadLine());
                Console.WriteLine($"Quantos cartoes {Nome} tem: ");
                int Cartoes = int.Parse(Console.ReadLine());
                Console.WriteLine($"Cartão vermelho ou punição: (true ou false)");
                bool suspensao = bool.Parse(Console.ReadLine());

                Player jogador = new Player(Id,Nome,Apelido,Nascimento,Numero,Posicao,Qualidade,Cartoes,suspensao);
                lista_players.Add(jogador);

            }
            foreach(var x in lista_players)
            {
                string condicao = "";
                if(x.Suspensao)
                    condicao = "SUSPENSO";
                else
                    condicao = "Tá ON";
                Console.WriteLine($"{x.Posicao}: {x.Numero} - {x.Nome} ({x.Apelido}) - {x.Nascimento} CONDIÇÃO: {condicao}");
            }

            Console.WriteLine("Insira o nome do time:");
            string NomeTime = Console.ReadLine();
            Console.WriteLine("Insira o apelido do time:");
            string ApelidoTime = Console.ReadLine();
            Console.WriteLine("Insira a fundação do time:");
            string FundacaoTime = Console.ReadLine();
            Time time = new Time(NomeTime,ApelidoTime,FundacaoTime,lista_players);
            ListaTimes.Add(time);
        }
        foreach(var x in ListaTimes)
        {
            for( int i = 0; i<11; i++)
            {
                if(i<11)
                    Console.WriteLine($"{x.Relacionados[i].Nome} = Titular");
                else if (i>11)
                    Console.WriteLine($"{x.Relacionados[i].Nome} = Reserva");

            }
        }
    }
}