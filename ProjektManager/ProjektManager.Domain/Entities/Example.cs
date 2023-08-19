using ProjektManager.Domain.Base.Entities;

namespace ProjektManager.Domain.Entities
{
    public class Example : BaseEntity
    {
        public Guid UserStoryId { get; private set; }
        public UserStory UserStory { get; private set; }
        public string Context { get; private set; }
        public string Action { get; private set; }
        public string Result { get; private set; }
    }
}
