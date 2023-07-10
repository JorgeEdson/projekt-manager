using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class Profile:BaseEntity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
