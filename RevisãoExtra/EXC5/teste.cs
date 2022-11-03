// mundo teste = new mundo();
// teste.roda();

public class mundo
{
    public void roda()
    {
        List<Player> jogas = new List<Player>();
        Player jogador1 = new Player(1,"jogador1","joga1","05/05/03",1,"goleiro",05,0,false);
        Player jogador2 = new Player(2,"jogador2","joga2","05/05/03",2,"goleiro",10,0,false);
        Player jogador3 = new Player(3,"jogador3","joga3","05/05/03",3,"goleiro",40,0,false);
        Player jogador4 = new Player(4,"jogador4","joga4","05/05/03",4,"goleiro",15,0,false);
        Player jogador5 = new Player(5,"jogador5","joga5","05/05/03",5,"goleiro",100,0,false);
        Player jogador6 = new Player(13,"jogador6","joga1","05/05/03",1,"goleiro",05,0,false);
        Player jogador7 = new Player(223,"jogador7","joga2","05/05/03",2,"goleiro",10,0,false);
        Player jogador8 = new Player(3456,"jogador8","joga3","05/05/03",3,"goleiro",40,0,false);
        Player jogador9 = new Player(433,"jogador9","joga4","05/05/03",4,"goleiro",15,0,false);
        Player jogador10 = new Player(55,"jogador10","joga5","05/05/03",5,"goleiro",52,0,false);
        Player jogador11 = new Player(56,"jogador11","joga5","05/05/03",5,"goleiro",79,0,false);
        Player jogador12 = new Player(567,"jogador12","joga5","05/05/03",5,"goleiro",89,0,false);
        Player jogador13 = new Player(5345,"jogador13","joga5","05/05/03",5,"goleiro",48,0,false);
        Player jogador14 = new Player(522,"jogador14","joga5","05/05/03",5,"goleiro",13,0,false);
        Player jogador16 = new Player(577,"jogador15","joga5","05/05/03",5,"goleiro",16,0,false);
        Player jogador15 = new Player(566,"jogador16","joga5","05/05/03",5,"goleiro",76,0,false);
        Player jogador17 = new Player(589,"jogador17","joga5","05/05/03",5,"goleiro",75,0,false);
        Player jogador18 = new Player(565,"jogador18","joga5","05/05/03",5,"goleiro",15,0,false);
        Player jogador19 = new Player(588,"jogador19","joga5","05/05/03",5,"goleiro",0,0,false);
        Player jogador20 = new Player(589,"jogador20","joga5","05/05/03",5,"goleiro",78,0,false);
        Player jogador21 = new Player(5678,"jogador21","joga5","05/05/03",5,"goleiro",85,0,false);
        Player jogador22 = new Player(5345,"jogador22","joga5","05/05/03",5,"goleiro",65,0,false);
        Player jogador23 = new Player(564,"jogador23","joga5","05/05/03",5,"goleiro",15,0,false);
        jogas.Add(jogador1);
        jogas.Add(jogador2);
        jogas.Add(jogador3);
        jogas.Add(jogador4);
        jogas.Add(jogador5);
        jogas.Add(jogador6);
        jogas.Add(jogador7);
        jogas.Add(jogador8);
        jogas.Add(jogador9);
        jogas.Add(jogador10);
        jogas.Add(jogador11);
        jogas.Add(jogador12);
        jogas.Add(jogador13);
        jogas.Add(jogador14);
        jogas.Add(jogador15);
        jogas.Add(jogador16);
        jogas.Add(jogador17);
        jogas.Add(jogador18);
        jogas.Add(jogador19);
        jogas.Add(jogador20);
        jogas.Add(jogador21);
        jogas.Add(jogador22);
        jogas.Add(jogador23);

        Time time = new Time("blablba","AOBA","5/5/45",jogas);
        time.RelacionarJogadores(jogas);
        foreach(var x in time.Relacionados)
            Console.WriteLine($"{x.Nome} {x.Qualidade}");  
    }
}