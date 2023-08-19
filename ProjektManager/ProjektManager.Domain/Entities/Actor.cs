using ProjektManager.Domain.Base.Entities;

namespace ProjektManager.Domain.Entities
{
    public class Actor : BaseEntity
    {
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }
    }
}
