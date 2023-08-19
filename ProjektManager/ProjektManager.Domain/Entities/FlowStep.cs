using ProjektManager.Domain.Base.Entities;
using ProjektManager.Domain.Enuns;

namespace ProjektManager.Domain.Entities
{
    public class FlowStep : BaseEntity
    {
        public Guid UseCaseId { get; private set; }
        public UseCase UseCase { get; private set; }
        public string Description { get; private set; }
        public int Order { get; private set; }
        public FlowStepType FlowStepType { get; private set; }
    }
}
