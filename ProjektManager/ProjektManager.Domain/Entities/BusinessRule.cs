using ProjektManager.Domain.Base.Entities;

namespace ProjektManager.Domain.Entities
{
    public class BusinessRule : BaseEntity
    {
        public Guid UserStoryId { get; private set; }
        public UserStory UserStory { get; private set; }
        public string Description { get; private set; }
    }
}
