namespace SpecMind.Domain.Entities
{
    public class Feature
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}