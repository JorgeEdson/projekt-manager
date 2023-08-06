namespace ProjektManager.Core.Domain.Entities
{
    public class Objective : TapSession
    {
        public Objective(Tap tap, string description) : base(tap, description)
        {
        }
    }
}
