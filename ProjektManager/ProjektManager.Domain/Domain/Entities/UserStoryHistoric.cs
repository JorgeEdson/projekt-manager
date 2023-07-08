using ProjektManager.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities
{
    public class UserStoryHistoric : BaseEntity
    {
        public int UserStoryId { get; set; }
        public UserStory UserStory { get; set; }
        public Status Status { get; set; }
        public RequirementSize RequirementSize { get; set; }
        public List<Actor> Actors { get; set; }
        public string IWant { get; set; }
        public string SoThat { get; set; }
        public List<BusinessRule> BusinessRules { get; set; }
        public List<Example> Examples { get; set; }
    }
}
