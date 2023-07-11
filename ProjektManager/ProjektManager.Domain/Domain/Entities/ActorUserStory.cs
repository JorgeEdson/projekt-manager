using ProjektManager.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities
{
    public class ActorUserStory: BaseEntity
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int UserStoryId { get; set; }
        public UserStory UserStory { get; set; }
    }
}
