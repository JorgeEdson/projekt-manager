using ProjektManager.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities
{
    public class ActorUseCase: BaseEntity
    {
        public Guid ActorId { get; private set; }

        public Actor Actor { get; private set; }

        public Guid UseCaseId { get; private set; }

        public UseCase UseCase { get; private set; }         

    }
}
