public class GameManager
{
	private Player[] players = new Player[2];
	private int playerIndex  = 0;
	private GameBoard gameBoard;

    public GameManager(Player player1, Player player2, GameBoard gameBoard)
    {
		this.players[0] = player1;
		this.players[1] = player2;
		this.gameBoard = gameBoard;
    }

	public void Run(){
		GameWindow window = new GameWindow();
		while(true){
			window.Render(gameBoard);
			Position move = players[playerIndex].RequestMove(gameBoard);
			playerIndex = (playerIndex + 1) % 2;

			gameBoard.ExecuteMove(move,players[playerIndex].disk);
		}

	}
}
