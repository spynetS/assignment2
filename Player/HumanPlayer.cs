public class HumanPlayer : Player
{
    public HumanPlayer()
    {
		disk=Disk.WHITE;
    }

    public HumanPlayer(string name, Disk disk) : base(name, disk)
    {
    }

    public override Position RequestMove(GameBoard board, List<Position> validMoves)
    {
		Position position;
		do{

			Console.WriteLine("Choose <x> <y>");
			string input = Console.ReadLine();
			int x = int.Parse(input.Split(" ")[0]);
			int y = int.Parse(input.Split(" ")[1]);
			position = new Position(x,y);
		}
		while(!board.IsValidMove(position,disk));
		return position;
    }

}
