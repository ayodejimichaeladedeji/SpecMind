namespace SpecMind.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<Result<string>> CreateUser(CreateUserDTO createUserDto);
    }
}