using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public Guid? Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }

        protected BaseEntity(DateTime createdAt, User user)
        {
            CreatedAt = createdAt;
            User = user;
            UserId = user.UserId;
        }
        protected BaseEntity(){}
    }
}
