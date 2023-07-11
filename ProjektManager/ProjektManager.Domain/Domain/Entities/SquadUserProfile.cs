
using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class SquadUserProfile:BaseEntity
    {
        public Guid SquadId { get; private set; }
        public Squad Squad { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private set; }
        

    }
}
