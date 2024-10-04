internal class Program
{
    private static void Main(string[] args)
    {
		GameManager manager = new GameManager(new HumanPlayer("alfred",Disk.WHITE),
                                      new HumanPlayer("alfred2",Disk.BLACK),
                                      new GameBoard());
		manager.Run();
    }
}
