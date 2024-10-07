public class GameManager
{
	private Player[] players = new Player[2];
	private int playerIndex  = 0;
	private GameBoard gameBoard;

    public GameManager(Player player1, Player player2, GameBoard gameBoard)
    {
		this.players[0] = player1;
		this.players[1] = player2; this.gameBoard = gameBoard;
    }

	private Player GetPlayer(){
		return players[playerIndex];
	}
	private Player NextPlayer(){
		playerIndex = (playerIndex + 1) % 2;
		return players[playerIndex];
	}

	public void Run(){
		GameWindow window = new GameWindow();
		while(true){

			window.Render(gameBoard,players[playerIndex].disk);
			List<Position> validMovies = gameBoard.GetValidMoves(players[playerIndex].disk);

			if(validMovies.Count > 0){
				Position move = GetPlayer().RequestMove(gameBoard,validMovies);
				gameBoard.ExecuteMove(move,GetPlayer().disk);

				NextPlayer();
			}
			else{
				Console.WriteLine(NextPlayer().name+" Won!");
				break;
			}
		}

	}
}
