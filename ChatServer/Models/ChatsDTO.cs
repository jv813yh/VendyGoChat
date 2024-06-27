using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatServer.Models
{
    public class ChatsDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; private set; }

        public int User1Id { get; set; }
        public int User2Id { get; set; }



        public UserDTO User1 { get; set; }
        public UserDTO User2 { get; set; }
        public ICollection<MessageDTO> Messages { get; set; }

    }
}
