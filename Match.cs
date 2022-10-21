namespace LAB1;

public class Match
{
    public decimal Rate { get; }
    public DateTime Date { get; }
            
    public string UserName { get; }
            
    public string EnemyName { get; }

    public Match( string userName, string enemyName, decimal rate, DateTime date)
    {
        UserName = userName;
        EnemyName = enemyName;
        Rate = rate;
        Date = date;
    }
}