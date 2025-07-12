namespace SpecMind.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public int CreatedByUserId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int OrganisationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}