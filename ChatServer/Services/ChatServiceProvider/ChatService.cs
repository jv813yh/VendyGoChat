using ChatServer.Data.DbContexts;

namespace ChatServer.Services.ChatServiceProvider
{
    public class ChatService
    {
        private readonly UserMembershipDbContext _dbContext;

        public ChatService(UserMembershipDbContextFactory dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }

    }
}
