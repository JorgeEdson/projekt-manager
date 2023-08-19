using ProjektManager.Core.Domain.Entities.Base;
using ProjektManager.Core.Domain.ValueObjects.Base;

namespace ProjektManager.Core.Domain.Entities
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
