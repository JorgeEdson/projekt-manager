using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class AcceptanceCriteria : BaseEntity
    {
        public int RequirementId { get; set; }
        public Requirement Requirement { get; set; }
        public string Description { get; set; }
        public bool Comply { get; set; }
    }
}
