using ProjektManager.Domain.Base.Entities;
using ProjektManager.Domain.Enuns;

namespace ProjektManager.Domain.Entities
{
    public class Requirement : BaseEntity
    {
        public string UniqueId { get; private set; }
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }
        public string Description { get; private set; }
        public RequirementType RequirementType { get; private set; }
        public RequirementSize RequirementSize { get; private set; }
        public List<Requirement>? Dependencies { get; private set; }
        public List<AcceptanceCriteria>? AcceptanceCriterias { get; private set; }
    }
}
