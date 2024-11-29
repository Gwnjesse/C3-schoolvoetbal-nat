using BettingApp.Services;

class Program
{
    static void Main(string[] args)
    {
        var accountService = new AccountService();
        var matchService = new MatchService();

        Console.WriteLine("Welkom bij 4S Gokken!");
        Console.WriteLine("1. Nieuw account aanmaken");
        Console.WriteLine("2. Inloggen");
        Console.WriteLine("3. Beheer wedstrijden");

        var keuze = Console.ReadLine();

        if (keuze == "1")
        {
            Console.Write("Voer een gebruikersnaam in: ");
            var username = Console.ReadLine();
            Console.Write("Voer een wachtwoord in: ");
            var password = Console.ReadLine();

            var account = accountService.CreateAccount(username, password);
        }
        else if (keuze == "2")
        {
            Console.Write("Gebruikersnaam: ");
            var username = Console.ReadLine();
            Console.Write("Wachtwoord: ");
            var password = Console.ReadLine();

            var account = accountService.Login(username, password);
            if (account != null)
            {
                Console.WriteLine($"Ingelogd als {account.Username}. Huidige balans: {account.Balance} 4S-dollars.");
            }
            else
            {
                Console.WriteLine("Ongeldige inloggegevens.");
            }
        }
        else if (keuze == "3")
        {
            Console.WriteLine("Beheer wedstrijden:");
            Console.WriteLine("1. Voeg nieuwe wedstrijd toe");
            Console.WriteLine("2. Bekijk alle wedstrijden");

            var wedstrijdKeuze = Console.ReadLine();
            if (wedstrijdKeuze == "1")
            {
                Console.Write("Team A: ");
                var teamA = Console.ReadLine();
                Console.Write("Team B: ");
                var teamB = Console.ReadLine();
                Console.Write("Datum en tijd (yyyy-MM-dd HH:mm): ");
                var time = DateTime.Parse(Console.ReadLine());

                matchService.AddMatch(teamA, teamB, time);
            }
            else if (wedstrijdKeuze == "2")
            {
                matchService.ListMatches();
            }
        }
    }
}
