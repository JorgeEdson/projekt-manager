using ProjektManager.Domain.Base.Entities;

namespace ProjektManager.Domain.Entities
{
    public class Squad : BaseEntity
    {
        public string Name { get; set; }
        public List<UserProfile>? UsersProfiles { get; private set; }
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }
    }
}
