namespace SpecMind.Domain.Entities
{
    public class UserFeatureRole
    {
        public int UserId { get; set; }
        public int FeatureId { get; set; }
        public int FeatureRoleId { get; set; }
        public DateTime JoinedAt { get; set; }
    }
}