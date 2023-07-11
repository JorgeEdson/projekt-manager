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
        public List<Actor> Actors { get; set; }
        public RequirementTechnique RequirementTechnique { get; set; }
        public int SquadId { get; set; }
        public Squad Squad { get; set; }
        public int TapId { get; set; }
        public Tap Tap { get; set; }
        public bool Completed { get; set; }
    }
}
