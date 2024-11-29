using BettingApp.Models;
using BettingApp.Database;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Services
{
    public class AccountService
    {
        public Account CreateAccount(string username, string password)
        {
            using (var db = new BettingContext())
            {
                if (db.Accounts.Any(a => a.Username == username))
                {
                    Console.WriteLine("Een account met deze gebruikersnaam bestaat al.");
                    return null;
                }

                var account = new Account(username, password);
                db.Accounts.Add(account);
                db.SaveChanges(); 

                Console.WriteLine($"Account voor {username} is aangemaakt met een startbalans van 50 4S-dollars.");
                return account;
            }
        }

        public Account Login(string username, string password)
        {
            using (var db = new BettingContext())
            {
                var account = db.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
                if (account == null)
                {
                    Console.WriteLine("Ongeldige gebruikersnaam of wachtwoord.");
                }
                return account;
            }
        }
    }
}
