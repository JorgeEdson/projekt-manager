using ProjektManager.Domain.Base.ValueObjects;
using ProjektManager.Domain.ValueObjects;

namespace ProjektManager.Domain.Entities
{
    public abstract class TapSession : BaseValueObject
    {
        #region Properties
        public Premise? Premise { get; set; }
        public Restriction? Restriction { get; set; }
        public Objective? Objective { get; set; }
        public Justification? Justification { get; set; }
        public ExcludedEscoped? ExcludedEscoped { get; set; }
        public Risk? Risk { get; set; }
        public PaymentAgreement? PaymentAgreement { get; set; }
        #endregion


    }
}
