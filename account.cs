namespace BettingApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
            Balance = 50; 
        }
    }
}
