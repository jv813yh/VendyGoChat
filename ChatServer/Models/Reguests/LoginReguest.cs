namespace ChatServer.Models.Reguests
{
    public class LoginReguest
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public LoginReguest(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
