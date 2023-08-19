using ProjektManager.Domain.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Domain.Entities
{
    public class ActorUserStory : BaseEntity
    {
        public Guid ActorId { get; private set; }
        public Actor Actor { get; private set; }
        public Guid UserStoryId { get; private set; }
        public UserStory UserStory { get; private set; }
    }
}
