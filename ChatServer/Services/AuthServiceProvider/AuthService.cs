using ChatServer.Data.DbContexts;
using ChatServer.Models;
using ChatServer.Models.Reguests;
using Microsoft.EntityFrameworkCore;

namespace ChatServer.Services.AuthServiceProvider
{
    // 
    public class AuthService : IAuthService
    {
        private readonly UserMembershipDbContext _dbContext;

        public AuthService(UserMembershipDbContextFactory dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }

        public async Task RegisterUser(RegistrationReguest request)
        {
            UserDTO userDto = new UserDTO(request.UserName, request.Password, request.Email);

            _dbContext.Users.Add(userDto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<UserDTO>? LoginUser(LoginReguest request)
        {
            UserDTO? userDto = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email);

            if (userDto != null && VerifyPassword(request.Password, userDto.PasswordHash))
            {
                return userDto;
            }

            return null;
        }


        private string HashPassword(string password)
        {
            return string.Empty;
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            return true;
        }
    }
}
