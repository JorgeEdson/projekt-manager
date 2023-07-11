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
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Objective> Objectives  { get; set; }
        public List<Justification> Justifications { get; set; }
        public List<Stakeholder> Stakeholder { get; set; }
        public List<Premise> Premises { get; set; }
        public List<Restriction> Restrictions { get; set; }
        public List<ExcludedEscoped> ExcludedEscopes { get; set; }
        public List<Risk> Riskiness { get; set; }
        public List<PaymentAgreement> PaymentAgreements { get; set; }
    }
}
