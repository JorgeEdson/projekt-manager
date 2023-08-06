namespace ProjektManager.Core.Domain.Entities
{
    public class ExcludedEscoped : TapSession
    {
        public ExcludedEscoped(Tap tap, string description) : base(tap, description)
        {
        }
    }
}
