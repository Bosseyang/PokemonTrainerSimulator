using System.Net.Security;

public abstract class Pokemon
{
    public string name;
    public int level;

    //Property: Validate Name
    public string Name
    {

        get => name;
        set
        {   
            if (value.Length < 2 || value.Length > 15)
                throw new ArgumentException("Name must be between 2 and 15 characters.");
            name = value;
        }
    }

    //Property: Validate Level
    public int Level
    {
        get => level;
        set
        {
            if (value < 1)
                throw new ArgumentException("Level must be more than 1.");
            level = value;
        }
    }

    public ElementType Type { get; protected set; }
    public List<Attack> Attacks { get; }

    public Pokemon(string name, int level, List<Attack> attacks)
    {
        Name = name;
        Level = level;
        Attacks = attacks;
    }
    public void RandomAttack()
    {
        // Picks a random attack from the list of attacks and invokes its .Use-method.
        var rand = new Random();
        var attack = Attacks[rand.Next(Attacks.Count)];
        attack.Use(Level);

    }

    public void Attack()
    {
        // Lets the user pick an attack from the list of attacks and invoke its .Use-method.
        Console.WriteLine($"Pick an attack to use for {Name}: ");
        //Using a foreach now since we only need to read from the list
        int index = 0;
        foreach (Attack attack in Attacks) {
            Console.WriteLine($"{index+1}: {attack.Name}");
            index++;
        }
        if (int.TryParse(Console.ReadLine(), out int choice) &&
             choice >= 1 && choice <= Attacks.Count)
        {
            Attacks[choice - 1].Use(Level);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void RaiseLevel()
    {
        // That should increment the level of the given pokemon and print that the pokemon has leveled up.
        Level++;
        Console.WriteLine($"{Name} leveled up to {Level}!");
    
    }
}