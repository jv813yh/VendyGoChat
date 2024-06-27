namespace ChatServer.Models.Reguests
{
    public class RegistrationReguest
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }

        public RegistrationReguest(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }
    }
}
