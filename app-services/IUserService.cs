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
