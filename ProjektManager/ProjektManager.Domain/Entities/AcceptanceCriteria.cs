using ProjektManager.Domain.Base.Entities;

namespace ProjektManager.Domain.Entities
{
    public class AcceptanceCriteria : BaseEntity
    {
        public Guid RequirementId { get; private set; }
        public Requirement Requirement { get; private set; }
        public string Description { get; private set; }
        public bool Comply { get; private set; }
    }
}
