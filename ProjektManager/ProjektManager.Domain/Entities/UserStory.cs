using ProjektManager.Domain.Base.Entities;
using ProjektManager.Domain.Enuns;

namespace ProjektManager.Domain.Entities
{
    public class UserStory : BaseEntity
    {
        public Status Status { get; private set; }
        public RequirementSize RequirementSize { get; private set; }
        public List<Actor>? Actors { get; private set; }
        public string IWant { get; private set; }
        public string SoThat { get; private set; }
        public List<BusinessRule>? BusinessRules { get; private set; }
        public List<Example>? Examples { get; private set; }
    }
}
