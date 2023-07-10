using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities.Base
{
    public enum RequerimentTechnique
    {
        UseCase,
        UserStory
    }

    public enum RequerimentSize
    {
        Small,
        Medium,
        Large
    }

    public enum RequerimentType
    {
        Functional,
        NonFunctional,
        User,
        System,
        Business
    }

    public enum Status
    {
        Selectable,
        InProgress,
        ReadForAcceptance,
        Validation,
        Validated,
        Done
    }

    public enum ActivityType
    {
        Development,
        Documentation
    }

    public enum FlowStepType
    {
        Principal,
        Alternative,
        Exception
    }
}
