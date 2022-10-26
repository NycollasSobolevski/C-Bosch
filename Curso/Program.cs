// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
World world = new World();
world.WorldRodando();



public class Curso
{
    public int Code{get;set;}
    public string Name{get;set;}
    public int CargaHoraria{get;set;}

    public void Add(int code, string name, int CargaHoraria)
    {
        this.Code = code;
        this.Name = name;
        this.CargaHoraria = CargaHoraria;
    }
}

public class Alunos
{
    public int CdCurso{get;set;}
    public string Nome{get;set;}
    public int Matricula{get;set;}
    public float Media{get;set;}

    public void Add(int cdCurso, string name, int matricula)
    {
        this.Nome = name;
        this.Matricula = matricula;
        this.CdCurso = cdCurso;
    }
    public void AddNota(float media)
    {
        this.Media = media;
    }
}


public class World
{
    public static Alunos [] AlunosList = new Alunos[100];
    public static Curso [] CursosList = new Curso[100];
    public static int IndexAlunos = 0;
    public static int IndexCursos = 0;
    public int escolha = 0;
    public static int Aprovados=0;
    public static int Reprovados=0;


    public void WorldRodando()
    {
        while (true)
        {
            Aprovados =0;
            Reprovados =0;
            
            Console.WriteLine("\n\n\nQual opção deseja escolher?");
            Console.WriteLine("1 - Cadastrar curso");
            Console.WriteLine("2 - Consultar curso");
            Console.WriteLine("3 - Cadastrar Aluno");
            Console.WriteLine("4 - Cadastrar Nota ");
            Console.WriteLine("5 - Estatísticas");
            Console.Write("6 - Sair\n> ");


            this.escolha = int.Parse(Console.ReadLine());
            switch(escolha)
            {
                case 1:
                    Console.WriteLine("Codigo:\n> ");
                    int codee = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nome:\n> ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Carga horaria:\n> ");
                    int ch = int.Parse(Console.ReadLine());

                    Curso curso = new Curso();
                    curso.Add(codee,nome,ch);

                    World.CursosList[IndexCursos] = curso;
                    IndexCursos++;
                break;

                case 2:
                    foreach(var x in CursosList)
                        if (x != null)
                            Console.WriteLine($"{x.Code} --- {x.Name}");
                        else
                            break;
                break;
                    
                case 3:
                    bool CursoExistente = false;
                    Console.WriteLine("um");
                    Console.WriteLine("Cod do curso:\n> ");
                    int codecurso = int.Parse(Console.ReadLine());
                    foreach(var x in CursosList)
                        if (codecurso == x.Code)
                            CursoExistente = true;
                    if (CursoExistente == false)
                        {Console.WriteLine("Curso Inexistente!!");
                        break;}
                    Console.WriteLine("Nome:\n> ");
                    string nomeAluno = Console.ReadLine();
                    Console.WriteLine("Matricula:\n> ");
                    int matricula = int.Parse(Console.ReadLine());
                    Alunos aluno = new Alunos();
                    aluno.Add(codecurso,nomeAluno,matricula);
                break;

                case 4:
                    Console.WriteLine("Digite o codigo de curso");
                    int codeCurso4 = int.Parse(Console.ReadLine());
                    foreach(var x in AlunosList)
                        if (codeCurso4 == x.CdCurso)
                        {
                            Console.WriteLine($"Insira a nota do aluno {x.Nome}");
                            float nota = float.Parse(Console.ReadLine());
                            x.AddNota(nota);
                        }
                break;

                case 5:
                    Console.WriteLine("Digite o codigo de curso");
                    int codeCurso5 = int.Parse(Console.ReadLine());
                    foreach(var x in AlunosList)
                    {
                        if (x.Media < 7)
                        {
                            World.Reprovados++;
                        }
                        else if (x.Media > 7)
                        {
                            World.Aprovados++;
                        }
                    }
                break;

                case 6:
                    Console.WriteLine("um");
                break;
            }
            


        }
    }

}