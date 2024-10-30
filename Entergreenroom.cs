public class EnterGreenRoomCommand : Command
{
    private Player player;

    public EnterGreenRoomCommand(Player player) : base (" green room")
    {
        this.player = player;
        this.Name = "room"; 
    }

    public override void Execute(string argument)
    {
        GreenRoom greenRoom = new GreenRoom(player);
        greenRoom.Execute(); // Call the execute method of GreenRoom
    }
}
