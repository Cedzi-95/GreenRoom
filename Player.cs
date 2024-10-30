using System.Reflection.Metadata;

public class Player 
{
    public List<string> Inventory { get; private set; }

    public Player() 
    {
        
        Inventory = new List<string>();
        
    }

    public void Pickup(string item)
    {
       

        Inventory.Add(item);  
        Console.WriteLine($"You´ve picked up: {item}");
    }

    public void ShowInventory()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("Your inventory is empty");
            return;
        }

        foreach (var item in Inventory)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
