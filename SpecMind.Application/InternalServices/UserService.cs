namespace SpecMind.Application.InternalServices
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<Result<string>> CreateUser(CreateUserDTO createUserDto)
        {
            Result<string> result = new();
            User user = _mapper.Map<User>(createUserDto);
            bool createUser = await _userRepository.Add(user);

            if (!createUser)
            {
                result.ErrorMessage = "An error occurred";
            }

            result.Data = "User created successfully";
            return result;
        }
    }
}
