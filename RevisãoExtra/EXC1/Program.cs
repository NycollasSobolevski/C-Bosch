using System;


World mundo = new World();
mundo.Rodando();

public class World
{
    List<Pessoa> pessoas = new List<Pessoa>{};
    public int MaiorIdade {get;set;} = 0;
    public string MaiorNome {get;set;}


    public void Rodando()
    {
        int cont=0;
        while(cont<3)
        {
            Console.WriteLine($"Insira o nome do {cont+1}° aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Insira a idade de {nome}: ");
            int idade = int.Parse(Console.ReadLine());

            Pessoa irineu = new Pessoa(nome,idade);
            pessoas.Add(irineu);
            
            cont++; 
        }

        foreach(var x in pessoas)
        {
            Console.WriteLine($"{x.Nome} {x.Idade}");
            if (x.Idade > MaiorIdade)
            {
                MaiorIdade = x.Idade;
                MaiorNome = x.Nome;
            }
        }

        Console.WriteLine($"A pessoa com maior idade é {MaiorNome}");

    }
}