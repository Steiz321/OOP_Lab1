


namespace LAB1
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var player1 = new GameAccount("player1");
            var player2 = new GameAccount("player2");

            Console.WriteLine("Player1 info:");
            Console.WriteLine($"Player ID: {player1.AccountId}");
            Console.WriteLine($"Player username: {player1.UserName}");
            Console.WriteLine($"Player Rate: {player1.CurrentRate}");
            Console.WriteLine($"Player games played: {player1.GamesCount}");
            
            Console.WriteLine("\nPlayer2 info:");
            Console.WriteLine($"Player ID: {player2.AccountId}");
            Console.WriteLine($"Player username: {player2.UserName}");
            Console.WriteLine($"Player Rate: {player2.CurrentRate}");
            Console.WriteLine($"Player games played: {player2.GamesCount}\n");

            DiceGame game1 = new DiceGame(player1, player2, 100);
            DiceGame game2 = new DiceGame(player1, player2, 100);
            DiceGame game3 = new DiceGame(player1, player2, 200);
            DiceGame game4 = new DiceGame(player1, player2, 100);

            game1.GameImitation();
            game2.GameImitation();
            game3.GameImitation();
            game4.GameImitation();

            player1.GetStats();
            player2.GetStats();
        }
    }
}