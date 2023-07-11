using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public abstract class TapSession : BaseEntity
    {
        public string Description { get; set; }
        public int TapId { get; set; }
        public Tap Tap { get; set; }
    }
}
