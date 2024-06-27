using Microsoft.EntityFrameworkCore;

namespace ChatServer.Data.DbContexts
{
    public class UserMembershipDbContextFactory
    {
        private readonly string _connectionString;

        public UserMembershipDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public UserMembershipDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UserMembershipDbContext>()
                .UseSqlite(_connectionString);

            return new UserMembershipDbContext(optionsBuilder.Options);
        }
    }
}
