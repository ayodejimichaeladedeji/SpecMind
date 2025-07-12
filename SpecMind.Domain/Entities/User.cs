namespace SpecMind.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string EmailAddress { get; set; }
        public bool IsEmailVerified { get; set; }
        public required string HashedPassword { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastLogin { get; set; }
        public string? RefreshToken { get; set; }
    }
}