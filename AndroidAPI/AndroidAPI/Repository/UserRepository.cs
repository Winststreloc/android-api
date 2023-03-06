using AndroidAPI.Data;
using AndroidAPI.Dto;
using AndroidAPI.Interface;
using AndroidAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AndroidAPI.Repository;

public class UserRepository : IUserRepository
{
    private AndroidDbContext _context;

    public UserRepository(AndroidDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _context.Users.Select(u => u).ToListAsync();
    }

    public async Task CreateUser(UserDto userDto)
    {
        var user = new User()
        {
            FirstName = userDto.FirstName,
            SecondName = userDto.SecondName
        };
        await _context.AddAsync(user);
        await _context.SaveChangesAsync();
    }
}