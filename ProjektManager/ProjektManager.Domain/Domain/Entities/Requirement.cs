using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class Requirement : BaseEntity
    {
        public string UniqueId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string Description { get; set; }
        public int Version { get; set; }
        public RequirementType RequirementType { get; set; }
        public RequirementSize RequirementSize { get; set; }
        public List<Requirement> Dependencies { get; set; }
        public List<AcceptanceCriteria> AcceptanceCriterias { get; set; }
    }
}
