using AndroidAPI.Dto;
using AndroidAPI.Models;

namespace AndroidAPI.Interface;

public interface IUserRepository
{
    Task<List<User>> GetAllUsers();
    Task CreateUser(UserDto userDto);
}