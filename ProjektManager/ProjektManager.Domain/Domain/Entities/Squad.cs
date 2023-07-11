
using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class Squad:BaseEntity
    {
        public List<UserProfile> UsersProfiles { get; private set; }
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }

    }
}
