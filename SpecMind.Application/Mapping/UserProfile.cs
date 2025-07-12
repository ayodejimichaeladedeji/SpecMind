namespace SpecMind.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDTO, User>();
        }
    }
}