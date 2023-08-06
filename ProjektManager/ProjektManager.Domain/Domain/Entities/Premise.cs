namespace ProjektManager.Core.Domain.Entities
{
    public class Premise : TapSession
    {
        public Premise(Tap tap, string description) : base(tap, description)
        {
        }        
    }
}
