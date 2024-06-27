using ChatServer.Models;
using ChatServer.Models.Reguests;

namespace ChatServer.Services.AuthServiceProvider
{
    // This interface is used to define the methods that will be used to register and login users
    public interface IAuthService
    {
        // This method is used to register a user
        Task RegisterUser(RegistrationReguest request);

        // This method is used to login a user
        Task<UserDTO>? LoginUser(LoginReguest request);
    }
}
