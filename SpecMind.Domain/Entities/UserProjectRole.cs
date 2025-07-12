namespace SpecMind.Domain.Entities
{
    public class UserProjectRole
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public DateTime JoinedAt { get; set; }
        public int ProjectRoleId { get; set; }
    }
}