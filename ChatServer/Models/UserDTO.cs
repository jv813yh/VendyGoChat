using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatServer.Models
{
    public class UserDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string PasswordHash { get; private set; }
        public string Email { get; private set; }

        public UserDTO(string userName, string passwordHash, string email)
        {
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;
        }
    }
}
