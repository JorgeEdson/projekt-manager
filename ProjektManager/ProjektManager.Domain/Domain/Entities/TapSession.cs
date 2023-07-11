using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public abstract class TapSession : BaseEntity
    {
        public string Description { get; private set; }
        public Guid TapId { get; private set; }
        public Tap Tap { get; private set; }
    }
}
