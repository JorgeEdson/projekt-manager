﻿using ProjektManager.Core.Domain.Entities.Base;

namespace ProjektManager.Core.Domain.Entities
{
    public class UserProfile:BaseEntity
    {
        public Guid ProfileId { get; private set; }
        public Profile Profile { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public List<Squad>? Squads { get; private set; }

    }
}
