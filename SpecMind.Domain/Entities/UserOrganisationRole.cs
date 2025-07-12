namespace SpecMind.Domain.Entities
{
    public class UserOrganisationRole
    {
        public int UserId { get; set; }
        public int OrganisationId { get; set; }
        public DateTime JoinedAt { get; set; }
        public int OrganisationRoleId { get; set; }
    }
}