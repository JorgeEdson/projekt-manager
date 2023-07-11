using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class RequirementHistoric : BaseEntity
    {
        public Guid RequirementId { get; private set; }
        public Requirement Requirement { get; private set; }
        public string UniqueId { get; private set; }
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }
        public string Description { get; private set; }
        public int Version { get; private set; }
        public RequirementType RequirementType { get; private set; }
        public RequirementSize RequirementSize { get; private set; }
        public List<Requirement> Dependencies { get; private set; }
        public List<AcceptanceCriteria> AcceptanceCriterias { get; private set; }
    }
}
