// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");






// ######################################################################################################



int[] decimais = new int[]          // lista de numeros
{255,254,172,164};

int[] comp = new int[(decimais.Length)/2];


for (int i = 0; i < decimais.Length; i+=2)
{
    int numComp = (convert(decimais[i],decimais[i+1]));
    comp[i/2] = numComp;
}


foreach(var x in decimais)
{
    Console.Write($"{x} ");
}
Console.Write($"\n");
foreach(var x in comp)
{
    Console.Write($"{x} ");
}

int convert(int a, int b)
{
    a = a >> 4;

    b = b >> 4;

    int c = (a << 4) + b;
    // Console.Write($"{c}, ");
    return c;
}


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

foreach(var x in numDescomp)
{
    Console.Write($"{x} ");
}

