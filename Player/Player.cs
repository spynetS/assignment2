public abstract class Player
{
	public string name {get;set;}
	public Disk disk {get;set;}

    protected Player(string name, Disk disk)
    {
        this.name = name;
        this.disk = disk;
    }

    protected Player()
    {
    }


    /// <summary>Returns the index of the 8x8 matrix the player wants to move to</summary>
    public abstract Position RequestMove(GameBoard board, List<Position> validMoves);
}
