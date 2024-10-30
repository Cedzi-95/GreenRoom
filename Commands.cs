public abstract class Command
{
    public string Name { get; protected set; }

    protected Command(string name)
    {
        Name = name;
    }

    public abstract void Execute(string argument);
}

public class HelpGreenCommand : Command
{
    public HelpGreenCommand() : base("help") { }

    public override void Execute(string argument)
    {
        Console.WriteLine("List of commands:");
        Console.WriteLine("- Type 'help' to View the menu");
        Console.WriteLine("- Type 'room' To enter the green room  ");
        Console.WriteLine("- Type 'inventory' check if you have the key");
        Console.WriteLine("- Type 'Exit' or 'stop' to exit the green room");
    }
}



public class InventoryCommand : Command
{
    private Player player;

    public InventoryCommand(Player player) : base("inventory")
    {
        this.player = player;
    }

    public override void Execute(string argument)
    {
        // greenRoom.key = "greenkey";
        
         player.ShowInventory();
    }
}

