using ProjektManager.Domain.Base.Entities;

namespace ProjektManager.Domain.Entities
{
    public class Profile : BaseEntity
    {
        public string Name { get; private set; }

        public List<User>? Users { get; private set; }
    }
}
