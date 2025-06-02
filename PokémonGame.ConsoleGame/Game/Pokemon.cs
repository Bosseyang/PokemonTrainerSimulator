using System.Net.Security;

public abstract class Pokemon
{
    public string name;
    public int level;

    //Validate Name
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

    //Validate Level
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

    public ElementType Type { get; set; }
    public List<Attack> Attacks { get; }




    public void RandomAttack()
    {
        // Picks a random attack from the list of attacks and invokes its .Use-method.
    }

    public void Attack()
    {
        // Lets the user pick an attack from the list of attacks and invoke its .Use-method.
    }

    public void RaiseLevel()
    {
        // That should increment the level of the given pokemon and print that the pokemon has leveled up.
    }
}