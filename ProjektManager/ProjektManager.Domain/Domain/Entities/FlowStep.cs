using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class FlowStep : BaseEntity
    {
        public int UseCaseId { get; set; }
        public UseCase UseCase { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public FlowStepType FlowStepType { get; set; }
    }
}
