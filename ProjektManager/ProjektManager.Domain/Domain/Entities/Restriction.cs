

namespace ProjektManager.Core.Domain.Entities
{
    public class Restriction : TapSession
    {
        public Restriction(Tap tap, string description) : base(tap, description)
        {
        }
    }
}
