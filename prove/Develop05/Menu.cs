class Menu
{
    public int DisplayBaseMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
        Console.Write("Please enter an input: ");
        int input = int.Parse(Console.ReadLine());
        return input;
    }
    public int DisplaySubMenu()
    {
        Console.WriteLine("The types of goal are:");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("What type of goal would you like to make? ");
        int input = int.Parse(Console.ReadLine());
        return input;
    }
}