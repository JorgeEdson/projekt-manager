
using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class Squad:BaseEntity
    {
        public List<UserProfile> UsersProfiles { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
