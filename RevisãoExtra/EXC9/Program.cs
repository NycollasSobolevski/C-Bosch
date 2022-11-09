Pais brasil = new Pais("BRA","Brasil",8516000,214000000);
brasil.addFronteiras(new Pais("PER","Peru",1,1));
brasil.addFronteiras(new Pais("COL","Colombia",2,2));
brasil.addFronteiras(new Pais("GUI","Guiana",3,3));


Pais Argentina = new Pais("ARG","Argentina",8516000,214000000);
Argentina.addFronteiras(new Pais("GUI","Guiana",3,3));
Argentina.addFronteiras(new Pais("PER","Peru",1,1));
Argentina.addFronteiras(new Pais("COL","Colombia",2,2));
Argentina.addFronteiras(new Pais("GUI","Guiana",3,3));

brasil.addFronteiras(Argentina);
Console.WriteLine(brasil.Limitrofe(Argentina));


Console.WriteLine(brasil.VizinhosComum(Argentina));
foreach(var x in brasil.VizinhosComum(Argentina))
    {
        Console.WriteLine(x.Code);
    }


Console.WriteLine(brasil.Densidade());


