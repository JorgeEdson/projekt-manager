using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities.Base
{
    enum RequerimentTechnique
    {
        UseCase,
        UserStory
    }

    enum RequerimentSize
    {
        Small,
        Medium,
        Large
    }

    enum RequerimentType
    {
        Functional,
        NonFunctional,
        User,
        System,
        Business
    }

    enum Status
    {
        Selectable,
        InProgress,
        ReadForAcceptance,
        Validation,
        Validated,
        Done
    }

    enum ActivityType
    {
        Development,
        Documentation
    }

    enum FlowStepType
    {
        Principal,
        Alternative,
        Exception
    }
}
