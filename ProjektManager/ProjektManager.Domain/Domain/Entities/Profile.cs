using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class Profile:BaseEntity
    {
        #region Properties
        public string Name { get; private set; }
        public List<User>? Users { get; private set; }
        #endregion

        #region Constructors
        public Profile(DateTime createdAt, User user, string name) :base(createdAt, user)
        {
            Name = name;
        }
        public Profile()
        {

        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
