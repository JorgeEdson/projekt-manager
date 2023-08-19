using ProjektManager.Domain.Base.Entities;

namespace ProjektManager.Domain.Entities
{
    public class ActorUseCase : BaseEntity
    {
        public Guid ActorId { get; private set; }

        public Actor Actor { get; private set; }

        public Guid UseCaseId { get; private set; }

        public UseCase UseCase { get; private set; }

    }
}
