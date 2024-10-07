public class GameBoard
{
	public Disk[][] matrix = new Disk[8][];
	public List<Position> validMoves = new List<Position>();

	// all the directions to check (rows columsn diaginals)
	private Position[] directions = new Position[]{new Position(-1, 0),
		new Position(1, 0),
		new Position(0, -1),
		new Position(0, 1),
		new Position(-1, -1),
		new Position(-1, 1),
		new Position(1, -1),
		new Position(1, 1)};


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

	public void ExecuteMove(Position position, Disk player){
		matrix[position.x][position.y] = player;

		// for each row or colimn or diags
		foreach(Position dir in directions){
			// apply the dir
			int x = position.x+dir.x;
			int y = position.y+dir.y;
			List<Position> toFlip = new List<Position>();

			// we go through the direction untill we find a opponent
			while( x < 8 && x >= 0 &&
				   y < 8 && y >= 0 &&
				   this.matrix[x][y] == (player == Disk.BLACK ? Disk.WHITE : Disk.BLACK)
			){
				toFlip.Add(new Position(x,y));
				x += dir.x;
				y += dir.y;
			}

			// if we find a omponent we return true because that sthe requere ment
			if(x < 8 && x >= 0 &&
			   y < 8 && y >= 0 &&
			   this.matrix[x][y] == player){

				foreach(Position pos in toFlip){
					this.matrix[pos.x][pos.y] = player;
				}

			}
		}
	}

	public List<Position> GetValidMoves(Disk player){
		List<Position> moves = new List<Position>();

		for (int y = 0; y < 8; y++) {
			for (int x = 0; x < 8; x++) {
				if(IsValidMove(new Position(x,y),player)){
					moves.Add(new Position(x,y));
				}
			}
		}

		this.validMoves = moves;
		return moves;
	}


	public void TurnPieces(Position position, Disk player){

	}

	public bool IsValidMove(Position position, Disk player){
		if (this.matrix[position.x][position.y] != Disk.EMPTY) return false;
		// for each row or colimn or diags
		foreach(Position dir in directions){
			// apply the dir
			int x = position.x+dir.x;
			int y = position.y+dir.y;

			bool foundOpponent = false;

			// we go through the direction untill we find a opponent
			while( x < 8 && x >= 0 &&
				   y < 8 && y >= 0 &&
				   this.matrix[x][y] == (player == Disk.BLACK ? Disk.WHITE : Disk.BLACK)
			){
				foundOpponent = true;
				x += dir.x;
				y += dir.y;
			}
			// if we find a omponent we return true because that sthe requere ment
			if(foundOpponent &&
			   x < 8 && x >= 0 &&
			   y < 8 && y >= 0 &&
			   this.matrix[x][y] == player){
				return true;
			}
		}
		return false;
	}
}
