
public class ComputerPlayer : Player
{

    public ComputerPlayer (string name, Disk disk) : base(name, disk)
    {
    }

    public override Position RequestMove(GameBoard board, List<Position> validMoves)
    {
		return validMoves[new Random().Next(0,validMoves.Count)];
    }
}
