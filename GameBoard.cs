public class GameBoard
{
	public Disk[][] matrix = new Disk[8][];
	/// <summary>
	/// Standard Constructor
	/// </summary>
	public GameBoard()
	{
		for(int i = 0; i < 8; i ++){
			matrix[i] = new Disk[8];
			for(int j = 0; j < 8; j ++){
				matrix[i][j] = Disk.EMPTY;
			}
		}

		matrix[4][4] = Disk.WHITE;
		matrix[4][3] = Disk.BLACK;
		matrix[3][3] = Disk.WHITE;
		matrix[3][4] = Disk.BLACK;

	}

	public void ExecuteMove(Position position, Disk disk){
		matrix[position.x][position.y] = disk;
	}

	public List<Position> GetValidMoves(){
		List<Position> moves = new List<Position>();
		for(int y = 0; y < 8; y ++){
			for(int x = 0; x < 8; x ++){
				if(matrix[x][y] == 0){
					moves.Add(new Position(x,y));
				}
			}
		}
		return moves;
	}

	public bool IsValidMove(Position position){
		return position.x < 8 && position.y < 8;
	}
}
