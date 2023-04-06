using AndroidAPI.Dto;
using AndroidAPI.Interface;
using AndroidAPI.Models.Responce;
using AndroidAPI.Models.ResponceTech;
using Microsoft.AspNetCore.Mvc;

namespace AndroidAPI.Controllers;

[Route("[controller]")]
public class UserTechController : Controller
{
    private readonly IUserTechRepository _userRepository;

    public UserTechController(IUserTechRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("get-all-users")]
    public List<UserResponse?> GetAllUser()
    {
        return _userRepository.GetAllUsers();
    }
    
    [HttpGet("get-user-by-id")]
    public UserResponse GetUserById([FromQuery]string id)
    {
        return _userRepository.GetUserById(id);
    }
    
    [HttpPost("login")]
    public AuthResponce Login([FromBody]UserDto userDto)
    {
        var response = new AuthResponce()
        {
            IsSuccess = false,
            Result = default
        };
        var result = _userRepository.GetUserByNumber(userDto.Number);
        if (result != null)
        {
            response.Result = result;
            response.IsSuccess = true;
            if (result.HashPassword != userDto.HashPassword)
            {
                response.IsSuccess = false;
            }
        }

        return response;
    }
    
    [HttpPost("create-user")]
    public AuthResponce CreateUser([FromBody]UserResponse? user)
    {
        if (_userRepository.UserExists(user.Number))
        {
            return new AuthResponce()
            {
                IsSuccess = false,
                Result = null
            };
        }
        var newUser = _userRepository.CreateUser(user);
        return new AuthResponce()
        {
            IsSuccess = true,
            Result = newUser
        };
    }

    [HttpPut("update-user")]
    public bool UpdateUser([FromBody] UserResponse? user)
    {
        if (user != null && _userRepository.UpdateUser(user))
        {
            return true;
        }
        return false;
    }
    
    [HttpDelete("delete-user")]
    public bool DeleteUser([FromBody]UserResponse user)
    {
        return _userRepository.DeleteUser(user);
    }
}