using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class UserProfile:BaseEntity
    {
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Squad> Squads { get; set; }

    }
}
