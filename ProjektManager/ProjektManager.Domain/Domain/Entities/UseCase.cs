using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class UseCase : BaseEntity
    {
        public Status Status { get; private set; }
        public Guid RequirementId { get; private set; }
        public Requirement Requirement { get; private set; }
        public List<FlowStep>? PrincipalFlow { get; private set; }
        public List<FlowStep>? AlternativeFlow { get; private set; }
        public List<FlowStep>? ExceptionFlow { get; private set; }
        public List<Actor>? Actors { get; private set; }

    }
}
