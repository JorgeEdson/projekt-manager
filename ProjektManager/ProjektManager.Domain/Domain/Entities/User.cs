
using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Profile> Profiles { get; set; }

    }
}
