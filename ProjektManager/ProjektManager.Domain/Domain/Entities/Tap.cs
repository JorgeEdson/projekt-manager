using ProjektManager.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities
{
    public class Tap : BaseEntity
    {
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public List<Objective>? Objectives  { get; private set; }
        public List<Justification>? Justifications { get; private set; }
        public List<Stakeholder>? Stakeholder { get; private set; }
        public List<Premise>? Premises { get; private set; }
        public List<Restriction>? Restrictions { get; private set; }
        public List<ExcludedEscoped>? ExcludedEscopes { get; private set; }
        public List<Risk>? Riskiness { get; private set; }
        public List<PaymentAgreement>? PaymentAgreements { get; private set; }
    }
}
