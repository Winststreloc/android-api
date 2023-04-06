using AndroidAPI.Interface;
using AndroidAPI.Models.Responce;
using AndroidAPI.Models.ResponceTech;

namespace AndroidAPI.Repository;

public class UserTechRepository : IUserTechRepository
{
    private List<UserResponse?> _userItemResponse= new List<UserResponse?>();
    
    public List<UserResponse?> GetAllUsers()
    {
        return _userItemResponse;
    }
    
    public bool UserExists(string number)
    {
        return _userItemResponse.Exists(u => u.Number == number);
    }

    public UserResponse GetUserById(string id)
    {
        return _userItemResponse.Find(u => u.Id == id);
    }

    public UserResponse? GetUserByNumber(string number)
    {
        return _userItemResponse.Find(u => u.Number == number);
    }

    public UserResponse? CreateUser(UserResponse? user)
    {
        _userItemResponse.Add(user);
        return user;
    }

    public bool UpdateUser(UserResponse user)
    {
        var oldUser = _userItemResponse.Find(u => u.Id == user.Id);
        if (oldUser == null) return false;
        _userItemResponse.Remove(oldUser);
        _userItemResponse.Add(user);
        return true;

    }
    
    public bool DeleteUser(UserResponse user)
    {
        if (!UserExists(user.Number)) return false;
        _userItemResponse.Remove(user);
        return true;
    }
}