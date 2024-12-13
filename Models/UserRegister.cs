namespace FinanceApp.Models;

public class UserRegister
{
    public Guid Id { get; init; }
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public UserRegister() { }

    public UserRegister(string userName, string email, string password)
    {
        Id = Guid.NewGuid();
        UserName = userName;
        Email = email;
        Password = password;
    }
}