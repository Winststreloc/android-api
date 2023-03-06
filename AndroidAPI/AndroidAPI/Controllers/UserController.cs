using AndroidAPI.Dto;
using AndroidAPI.Interface;
using AndroidAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndroidAPI.Controllers;

[Route("[controller]")]
public class UserController : Controller
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("get-all-users")]
    public async Task<List<User>> GetAllUsers()
    {
        return await _userRepository.GetAllUsers();
    }

    [HttpPost("create-user")]
    public async Task CreateUser(UserDto userDto)
    {
        await _userRepository.CreateUser(userDto);
    }
}