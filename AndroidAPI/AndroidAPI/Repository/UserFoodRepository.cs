using AndroidAPI.Interface;
using AndroidAPI.Models.Responce;


namespace AndroidAPI.Repository;

public class UserFoodRepository : IUserFoodRepository
{
    private List<UserItemResponse?> _userItemResponse = new List<UserItemResponse?>();

    public List<UserItemResponse?> GetAllUsers()
    {
        return _userItemResponse;
    }

    public bool UserExists(string number)
    {
        return _userItemResponse.Exists(u => u.Number == number);
    }

    public UserItemResponse? GetUserById(string id)
    {
        return _userItemResponse.Find(u => u.Id == id);
    }

    public UserItemResponse? GetUserByNumber(string number)
    {
        return _userItemResponse.Find(u => u.Number == number);
    }

    public UserItemResponse? CreateUser(UserItemResponse? user)
    {
        _userItemResponse.Add(user);
        return user;
    }
    public bool UpdateUser(UserItemResponse user)
    {
        var oldUser = _userItemResponse.Find(u => u.Id == user.Id);
        if (oldUser == null) return false;
        _userItemResponse.Remove(oldUser);
        _userItemResponse.Add(user);
        return true;
    }

    public bool DeleteUser(UserItemResponse user)
    {
        if (!UserExists(user.Number)) return false;
        _userItemResponse.Remove(user);
        return true;
    }
}