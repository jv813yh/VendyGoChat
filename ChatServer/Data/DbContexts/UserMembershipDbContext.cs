using ChatServer.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatServer.Data.DbContexts
{
    public class UserMembershipDbContext : DbContext
    {
        public DbSet<UserDTO> Users { get; set; }

        public UserMembershipDbContext(DbContextOptions<UserMembershipDbContext> options) : base(options)
        {

        }
    }
}
