namespace ProjektManager.Core.Domain.Entities
{
    public class PaymentAgreement : TapSession
    {
        public PaymentAgreement(Tap tap, string description) : base(tap, description)
        {
        }
    }
}
