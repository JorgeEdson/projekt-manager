namespace ProjektManager.Core.Domain.Entities
{
    public class Justification : TapSession
    {
        public Justification(Tap tap, string description) : base(tap, description)
        {
        }
    }
}
