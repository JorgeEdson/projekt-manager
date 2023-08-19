using ProjektManager.Domain.Base.Entities;
using ProjektManager.Domain.ValueObjects;

namespace ProjektManager.Domain.Entities
{
    public class TapHistoric : BaseEntity
    {
        public Guid TapId { get; private set; }
        public Tap Tap { get; private set; }
        public Project Project { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public List<Objective> Objectives { get; private set; }
        public List<Justification> Justifications { get; private set; }
        public List<Stakeholder> Stakeholder { get; private set; }
        public List<Premise> Premises { get; private set; }
        public List<Restriction> Restrictions { get; private set; }
        public List<ExcludedEscoped> ExcludedEscopes { get; private set; }
        public List<Risk> Riskiness { get; private set; }
        public List<PaymentAgreement> PaymentAgreements { get; private set; }
    }
}
