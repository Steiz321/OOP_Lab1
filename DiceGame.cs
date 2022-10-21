namespace LAB1;
public class DiceGame
{
    public GameAccount Player1 { get; }
    public GameAccount Player2 { get; }

    public decimal Rating { get; }

    private static Random rnd = new Random();
            
    public void GameImitation()
    {
        decimal number1 = rnd.Next(1, 7);
        decimal number2 = rnd.Next(1, 7);

        if (number1 > number2)
        {
            Player1.WinMatch(Player2.UserName, Rating);
            Player2.LoseMatch(Player1.UserName,Rating);
            Console.WriteLine($"{Player1.UserName} wins {Player2.UserName}!");
        }
        else if (number2 > number1) 
        {
            Player2.WinMatch(Player1.UserName, Rating);
            Player1.LoseMatch(Player2.UserName, Rating);
            Console.WriteLine($"{Player2.UserName} wins {Player1.UserName}!");
        }
        else
        {
            Player1.WinMatch(Player2.UserName, 0);
            Player2.WinMatch(Player1.UserName, 0);
            Console.WriteLine($"{Player1.UserName} and {Player2.UserName} have draw!");
        }
                
    }

    public DiceGame(GameAccount player1, GameAccount player2, decimal rate)
    {
        Player1 = player1;
        Player2 = player2;
        Rating = rate;
    }
}
