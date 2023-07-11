using ProjektManager.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities
{
    public class Actor : BaseEntity
    {
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }
    }
}
