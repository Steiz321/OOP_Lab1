namespace LAB1;

public class GameAccount
        {
            public string AccountId { get; }
            public decimal GamesCount { get; }
            public string UserName { get; }
            private List<Match> _allMatches = new List<Match>();

            public decimal CurrentRate
            {
                get
                {
                    decimal currentRate = 0;
                    foreach (var match in _allMatches)
                    {
                        currentRate += match.Rate;
                    }

                    return currentRate;
                }
            }

            private static decimal _initialRate = 1000;
            private static decimal _accountIdSeed = 1;
            private static decimal _initialGamesCount = 0;

            public void WinMatch (string enemyName, decimal rate)
            {
                if (rate < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(rate), "Rating can't be negative!");
                }
                
                var match = new Match(UserName, enemyName, rate, DateTime.Now);
                _allMatches.Add(match);
            }

            public void LoseMatch(string enemyName, decimal rate)
            {
                if (rate < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(rate), "Rating can't be negative!");
                }

                if (CurrentRate - rate < 0)
                {
                    throw new InvalidOperationException("You need more rating to create this game!");
                }
                
                var match = new Match( UserName, enemyName, -rate, DateTime.Now);
                _allMatches.Add(match);
            }

            public void GetStats()
            {
                var report = new System.Text.StringBuilder();

                decimal rating = 0;
                report.AppendLine("-------------------------------------------------------------");
                report.AppendLine($"{UserName} game log:");
                report.AppendFormat("\n|{0,20}|{1,20}|{2,20}|\n", "Enemy_name", "Current_rating", "Match_Date");
                foreach (var match in _allMatches)
                {
                    rating += match.Rate;
                    report.AppendFormat("|{0,20}|{1,20}|{2,20}|\n", match.EnemyName, rating, match.Date);
                }
                report.AppendLine("-------------------------------------------------------------\n");

                Console.WriteLine(report.ToString());
            }

            public GameAccount(string username)
            {
                UserName = username;
                GamesCount = _initialGamesCount;
                AccountId = _accountIdSeed.ToString();
                _accountIdSeed++;
                
                WinMatch("init", _initialRate);
            }
            
        }