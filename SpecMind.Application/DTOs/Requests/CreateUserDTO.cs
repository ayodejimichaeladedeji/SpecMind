namespace SpecMind.Application.DTOs.Requests
{
    public class CreateUserDTO
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string EmailAddress { get; set; }
        public required string Password { get; set; }
    }
}