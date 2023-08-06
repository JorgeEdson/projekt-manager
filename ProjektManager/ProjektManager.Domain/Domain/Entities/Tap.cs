using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class Tap : BaseEntity
    {
        #region Properties
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public List<Objective>? Objectives { get; private set; }
        public List<Justification>? Justifications { get; private set; }
        public List<Stakeholder>? Stakeholders { get; private set; }
        public List<Premise>? Premises { get; private set; }
        public List<Restriction>? Restrictions { get; private set; }
        public List<ExcludedEscoped>? ExcludedEscopes { get; private set; }
        public List<Risk>? Riskiness { get; private set; }
        public List<PaymentAgreement>? PaymentAgreements { get; private set; }
        #endregion

        #region Constructors
        public Tap(Project project, string title)
        {
            Project = project;
            ProjectId = project.Id;        
            Title = title;
        }
        public Tap(){}
        #endregion

        #region Public Methods
        public void SetDescription(string? description)
        {
            Description = description;
        }

        public void SetObjectives(List<Objective>? objectives)
        {
            Objectives = objectives;
        }

        public void SetJustifications(List<Justification>? justifications)
        {
            Justifications = justifications;
        }

        public void SetStakeholders(List<Stakeholder>? stakeholders)
        {
            Stakeholders = stakeholders;
        }

        public void SetPremises(List<Premise>? premises)
        {
            Premises = premises;
        }

        public void SetRestrictions(List<Restriction>? restrictions)
        {
            Restrictions = restrictions;
        }

        public void SetExcludedScopes(List<ExcludedEscoped>? excludedScopes)
        {
            ExcludedEscopes = excludedScopes;
        }

        public void SetRiskiness(List<Risk>? riskiness)
        {
            Riskiness = riskiness;
        }

        public void SetPaymentAgreements(List<PaymentAgreement>? paymentAgreements)
        {
            PaymentAgreements = paymentAgreements;
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
