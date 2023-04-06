using AndroidAPI.Models.Responce;
using AndroidAPI.Models.ResponceTech;

namespace AndroidAPI.Interface;

public interface IUserTechRepository
{
    List<UserResponse?> GetAllUsers();
    bool UserExists(string number);
    UserResponse GetUserById(string id);
    UserResponse? GetUserByNumber(string number);
    UserResponse? CreateUser(UserResponse? user);
    bool UpdateUser(UserResponse user);
    bool DeleteUser(UserResponse user);
}