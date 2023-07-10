
using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class SquadUserProfile:BaseEntity
    {
        public int SquadId { get; set; }
        public Squad Squad { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        

    }
}
