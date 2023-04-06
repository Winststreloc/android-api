
using AndroidAPI.Models.Responce;

namespace AndroidAPI.Interface;

public interface IUserFoodRepository
{
    List<UserItemResponse?> GetAllUsers();
    bool UserExists(string number);
    UserItemResponse? GetUserById(string id);
    UserItemResponse? GetUserByNumber(string number);
    UserItemResponse? CreateUser(UserItemResponse? user);
    bool UpdateUser(UserItemResponse user);
    bool DeleteUser(UserItemResponse user);
}