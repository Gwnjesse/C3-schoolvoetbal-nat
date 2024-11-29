using BettingApp.Database;
using BettingApp.Models;

namespace BettingApp.Services
{
    public class MatchService
    {
        public void AddMatch(string teamA, string teamB, DateTime scheduledTime)
        {
            using (var db = new BettingContext())
            {
                db.Database.EnsureCreated();
                var match = new Match(teamA, teamB, scheduledTime);
                db.Matches.Add(match);
                db.SaveChanges();
                Console.WriteLine($"Wedstrijd tussen {teamA} en {teamB} toegevoegd voor {scheduledTime}.");
            }
        }

        public void ListMatches()
        {
            using (var db = new BettingContext())
            {
                var matches = db.Matches.ToList();
                foreach (var match in matches)
                {
                    Console.WriteLine($"{match.Id}: {match.TeamA} vs {match.TeamB} - {match.ScheduledTime}");
                }
            }
        }
    }
}
