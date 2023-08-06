using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class Project: BaseEntity
    {
        #region Properties
        public List<Actor>? Actors { get; private set; }
        public RequirementTechnique RequirementTechnique { get; private set; }
        public Guid? SquadId { get; private set; }
        public Squad? Squad { get; private set; }
        public Guid? TapId { get; private set; }
        public Tap? Tap { get; private set; }
        #endregion

        #region Constructors
        public Project(RequirementTechnique requirementTechnique)
        {
            RequirementTechnique = requirementTechnique;
        }

        public Project(){}
        #endregion

        #region Public Methods
        public void SetActors(List<Actor>? actors) 
        {
            Actors = actors;
        }
        public void SetSquadId(Guid? squadId)
        {
            SquadId = squadId;
        }

        public void SetSquad(Squad? squad)
        {
            Squad = squad;
        }

        public void SetTapId(Guid? tapId)
        {
            TapId = tapId;
        }

        public void SetTap(Tap? tap)
        {
            Tap = tap;
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
