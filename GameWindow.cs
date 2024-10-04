public class GameWindow
{
	public void Render(GameBoard board){
		for(int y = 0; y < 8; y ++){
			for(int x = 0; x < 8; x ++){
				switch(board.matrix[x][y]){
					case Disk.EMPTY:
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("|"+x+","+y+ "|");
						break;
					case Disk.WHITE:
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("|");
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" # ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("|");
						break;
					case Disk.BLACK:
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("|");
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write(" # ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("|");
						break;
				}
			}
			Console.WriteLine("");
		}
	}

}
