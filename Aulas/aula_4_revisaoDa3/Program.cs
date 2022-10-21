// See https://aka.ms/new-console-template for more information
Edjalma edjalmafeliz = new Edjalma();
Edjalma edjalmaagressivo = new Edjalma();
Sword sword = new Sword();
edjalmaagressivo.Weapon = sword;
edjalmaagressivo.Attack(edjalmafeliz);

Console.WriteLine(edjalmafeliz.Life);


public abstract class Entity
{
    public string Name {get;protected set;}
    public int Life {get;protected set;}
    public int Damage {get;protected set;}
    public Weapon Weapon {get;set;}

    public abstract void Attack(Entity target);
    public abstract void ReciveDamage(int damage);
}

public abstract class Weapon
{
    public string Name {get; protected set;}
    public int Damage {get; protected set;}
}





public class Edjalma : Entity
{
    public int Shield{get;private set;}
    public Edjalma()
    {
        this.Name = "Edjalma";
        this.Life = 180;
        this.Damage = 10;
        this.Shield = 40;
    }
    public override void Attack(Entity target)
    {
        int damage = this.Damage / 2
            + this.Weapon.Damage*2;
        target.ReciveDamage(damage);
    }
    public override void ReciveDamage(int damage)
    {
        if (damage<5)
            return;
        this.Life -= damage;
    }
}





public class Gustavo : Entity
{
    public Gustavo()
    {
        this.Damage = 20;
        this.Life = 80;
        this.Name = "Gustavo Matador";
    }

    public override void Attack(Entity target)
    {
        int damage = this.Damage / 2
            + this.Weapon.Damage*2;
        target.ReciveDamage(damage);
    }

    public override void ReciveDamage(int damage)
    {
        if (damage<5)
            return;
        this.Life -= damage;
    }

}


public class Sword : Weapon
{
    public Sword()
    {
        this.Name = "Espada";
        this.Damage = 5;
    }
}


