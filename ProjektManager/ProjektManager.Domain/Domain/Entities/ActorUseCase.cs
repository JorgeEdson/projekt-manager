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
        public int ActorId { get; set; }

        public Actor Actor { get; set; }

        public int UseCaseId { get; set; }

        public UseCase UseCase { get; set; }         

    }
}
