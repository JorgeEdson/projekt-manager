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
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
