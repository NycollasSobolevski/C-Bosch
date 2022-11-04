MeuDelegate print = Console.WriteLine;
// print("hello world");

var pessoas = new List<Pessoa>()
{
    new Pessoa()
    {
        Nome = "Edjalma",
        Idade = 830
    },
    new Pessoa()
    {
        Nome = "Eu",
        Idade = 23
    },
    new Pessoa()
    {
        Nome = "Voces",
        Idade = 16
    }
};

ChameNVezes(print,10);
ChameNVezes(meuPrint,2);
ChameNVezes(delegate(string s)
{
    Console.WriteLine("Função anonima diz: " + s);
},2);
MeuDelegate func2 = s => Console.WriteLine("Lambda diz: " + s);
ChameNVezes(s => Console.WriteLine("lambda direto diz: " + s),3);

//----------------------------------------------------------------------------------
//  Usando Transformador
int[] lista = new int[] {1,2,3,4,5};
Transformador<int> quadrado = s => s*s;
var x = transforme(lista,quadrado);
foreach (var i in x)
{
    Console.WriteLine(i);
}
//----------------------------------------------------------------------------------

//----------------------------------------------------------------------------------
//  Usando WHERE
Func<Pessoa,bool> MaioresIdade = p => p.Idade >= 18;
var Maior = pessoas.Where(MaioresIdade);
foreach(var item in Maior)
    Console.WriteLine(item.Nome);

//----------------------------------------------------------------------------------
//----------------------------------------------------------------------------------
// Usando MAX



//----------------------------------------------------------------------------------

void meuPrint(string s )
{
    Console.WriteLine("Mensagem: " + s);
}

void ChameNVezes(MeuDelegate f, int n)
{
    for( int i = 0; i < n; i++)
        f("Hello World!");
}

int[] transforme(int[] entrada, Transformador<int> t)
{
    int[] saida = new int[entrada.Length] ;

    for (int i = 0; i < entrada.Length; i++)
    {
        saida[i] = t(entrada[i]);
    }
    return saida;
}

// int[] transforme(int[] entrada, Transformador t)
// {
//     int[] saida = new int[entrada.Length] ;
//
//     for (int i = 0; i < entrada.Length; i++)
//     {
//         saida[i] = t(entrada[i]);
//     }
//     return saida;
// }


public delegate void MeuDelegate(string s);
// public delegate int Transformador(int n);
public delegate T Transformador<T>(T n);
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

//Implementação com classse (incompleta)
// public abstract class MeuDelegateSoQueComClasse
// {
//     public abstract void Run(string s );
// }
// public class MeuPrint : MeuDelegateSoQueComClasse
// {
//     public override void Run(string s)
//     {
//         Console.WriteLine(s);
//     }
// }
