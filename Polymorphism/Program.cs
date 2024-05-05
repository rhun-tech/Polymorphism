public class Weapon
{
    protected string name;
    protected int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"Attacking with {name} - Damage: {damage}");
    }

    public string GetName()
    {
        return name;
    }
}

public class Sword : Weapon
{
    public Sword() : base("Sword", 20)
    {
    }

    public override void Attack()
    {
        base.Attack();
        Console.WriteLine("Swinging the sword!");
    }
}

public class Axe : Weapon
{
    public Axe() : base("Axe", 25)
    {
    }

    public override void Attack()
    {
        base.Attack();
        Console.WriteLine("Swinging the axe!");
    }
}

public class Bow : Weapon
{
    public Bow() : base("Bow", 15)
    {
    }

    public override void Attack()
    {
        base.Attack();
        Console.WriteLine("Shooting arrows with the bow!");
    }
}

public class Knight
{
    private string name;
    private Weapon weapon;

    public Knight(string name, Weapon weapon)
    {
        this.name = name;
        this.weapon = weapon;
    }

    public void Attack()
    {
        Console.WriteLine($"{name} is attacking!");
        weapon.Attack();
    }

    public void EquipWeapon(Weapon newWeapon)
    {
        weapon = newWeapon;
        Console.WriteLine($"{name} has equipped {weapon.GetName()}!");
    }

    // Method demonstrating polymorphism
    public void SpecialAttack(Weapon specialWeapon)
    {
        Console.WriteLine($"{name} is performing a special attack!");
        specialWeapon.Attack(); // Polymorphism: The actual behavior depends on the type of the weapon passed
    }
}

class Program
{
    static void Main()
    {
        Sword sword = new Sword();
        Axe axe = new Axe();
        Bow bow = new Bow();

        Knight knight = new Knight("Sir Lancelot", sword);

        knight.Attack();
        knight.EquipWeapon(axe);
        knight.Attack();

        knight.SpecialAttack(bow); // Demonstrating polymorphism by passing different types of weapons
    }
}
