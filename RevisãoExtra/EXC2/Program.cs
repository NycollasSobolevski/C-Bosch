Console.WriteLine("Escolha a altura: ");
int h = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha a Largura: ");
int l = int.Parse(Console.ReadLine());

Rect escolha = new Rect(h,l);
escolha.Mostrar();