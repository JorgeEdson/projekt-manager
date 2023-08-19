using ProjektManager.Domain.Entities;
namespace ProjektManager.Domain.Base.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
    }
}
