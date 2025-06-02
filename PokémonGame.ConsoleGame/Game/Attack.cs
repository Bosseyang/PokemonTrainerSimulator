public class Attack(string Name, ElementType Type, int BasePower)
{
    private string name { get; set; }
    private ElementType type { get; set; }
    private int basePower { get; set; }

    public void Use(int level)
    {

        Console.WriteLine($"Flamethrower hits with total power {BasePower+level}");
    }
}
