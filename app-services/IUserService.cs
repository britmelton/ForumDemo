using Domain;

namespace app_services;
public interface IUserService
{
    public Guid Register(RegisterUserCommand args);
}
public record RegisterUserCommand(
   string Username,
   string Password,
   DateTime Birthday
   );

public class UserService : IUserService
{
    private readonly IUserRepository _repo;

    public UserService(IUserRepository repo)
    {
        _repo = repo;
    }
    public Guid Register(RegisterUserCommand args)
    {
        var (username, password, birthday) = args;
        var user = new User(username, password, birthday);
        _repo.Create(user);
        return user.Id;
    }
}