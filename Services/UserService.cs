using FinanceApp.Data;
using FinanceApp.Models;

namespace FinanceApp.Service;

public class UserService
{
    private readonly FinanceAppDbContext _context;

    public UserService(FinanceAppDbContext context)
    {
        _context = context;
    }

    public async Task UserCreateAsync(UserRegister user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}