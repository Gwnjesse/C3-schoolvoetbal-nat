namespace BettingApp.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public DateTime ScheduledTime { get; set; }

        public Match(string teamA, string teamB, DateTime scheduledTime)
        {
            TeamA = teamA;
            TeamB = teamB;
            ScheduledTime = scheduledTime;
        }
    }
}
