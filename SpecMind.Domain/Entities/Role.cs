namespace SpecMind.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required RoleLevel Level { get; set; }
        public string? Description { get; set; }
    }
}