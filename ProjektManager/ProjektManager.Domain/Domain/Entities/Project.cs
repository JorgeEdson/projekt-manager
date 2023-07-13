using ProjektManager.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities
{
    public class Project: BaseEntity
    {
        public List<Actor>? Actors { get; private set; }
        public RequirementTechnique RequirementTechnique { get; private set; }
        public Guid? SquadId { get; private set; }
        public Squad? Squad { get; private set; }
        public Guid? TapId { get; private set; }
        public Tap? Tap { get; private set; }        
    }
}
