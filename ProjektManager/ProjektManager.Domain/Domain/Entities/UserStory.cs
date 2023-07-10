using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class UserStory : BaseEntity
    {
        public Status Status { get; set; }
        public RequirementSize RequirementSize { get; set; }
        public List<Actor> Actors { get; set; }
        public string IWant { get; set; }
        public string SoThat { get; set; }
        public List<BusinessRule> BusinessRules { get; set; }
        public List<Example> Examples { get; set; }
    }
}
