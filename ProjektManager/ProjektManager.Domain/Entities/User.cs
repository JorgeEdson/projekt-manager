using ProjektManager.Domain.Base.Entities;

namespace ProjektManager.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<Profile>? Profiles { get; private set; }
    }
}
