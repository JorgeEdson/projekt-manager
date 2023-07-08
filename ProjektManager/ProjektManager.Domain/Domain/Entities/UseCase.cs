using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class UseCase : BaseEntity
    {
        public Status Status { get; set; }
        public int RequirementId { get; set; }
        public Requirement Requirement { get; set; }
        public List<FlowStep> PrincipalFlow { get; set; }
        public List<FlowStep> AlternativeFlow { get; set; }
        public List<FlowStep> ExceptionFlow { get; set; }
        public List<Actor> Actors { get; set; }

    }
}
