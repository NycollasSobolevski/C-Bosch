var start = DateTime.Now;

// int[] decimais = new int[6880200];           //pegando tamanho de uma imagem
int[] decimais = new int[]
{40,60,74,22,73,89,182,124,207,242};            //Usando tamanho de uma lista

int[] comp = new int[(decimais.Length)/2];


for (int i = 0; i < decimais.Length; i+=2)
{
    int numComp = (convert(decimais[i],decimais[i+1]));
    comp[i/2] = numComp;
}

int convert(int a, int b)
{
    a = a >> 4;

    b = b >> 4;

    int c = (a << 4) + b;
    // Console.Write($"{c}, ");
    return c;
}


// foreach(var x in decimais)
// {
//     Console.Write($"{x} ");
// }

// Console.Write("\n");

// foreach(var x in comp)
// {
//     Console.Write($"{x} ");
// }




(int,int) descomprime(int a)
{
    int b = a;
    a = a >> 4;
    a = a << 4;

    b =  b - a;
    b = b << 4;
    // Console.Write($"{a}, {b}");
    return (a,b);
}

int[] numDescomp = new int[decimais.Length];


for (int i=0; i<comp.Length; i++)
{
    numDescomp[i*2] = descomprime(comp[i]).Item1;
    numDescomp[(i*2)+1] = descomprime(comp[i]).Item2;
}

// Console.Write("\n");
// foreach(var x in numDescomp)
// {
//     Console.Write($"{x} ");
// }
var end = DateTime.Now;
var timeDiff = (end - start).TotalMilliseconds;
Console.Write($"\n{timeDiff} ");