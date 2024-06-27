namespace ChatClient.MVVM.Models
{
    public class User
    {
        public string UserName { get; private set; }
        public string PasswordHash { get; private set; }
        public string Email { get; private set; }

        public User(string userName, string passwordHash, string email)
        {
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;
        }
    }
}
