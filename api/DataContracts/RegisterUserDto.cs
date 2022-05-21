namespace api.Contracts
{
    public record RegisterUserDto(
        string Username, 
        string Password,
        DateTime Birthday
        );
    
    public record UserDto(
        string Username,
        DateTime Birthday
        );

}
