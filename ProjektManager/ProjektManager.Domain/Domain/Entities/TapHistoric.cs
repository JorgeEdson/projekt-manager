using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class TapHistoric : BaseEntity
    {
        public int TapId { get; set; }
        public Tap Tap { get; set; }
        public Project Project { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Objective> Objectives { get; set; }
        public List<Justification> Justifications { get; set; }
        public List<Stakeholder> Stakeholder { get; set; }
        public List<Premise> Premises { get; set; }
        public List<Restriction> Restrictions { get; set; }
        public List<ExcludedEscoped> ExcludedEscopes { get; set; }
        public List<Risk> Riskiness { get; set; }
        public List<PaymentAgreement> PaymentAgreements { get; set; }
    }
}
