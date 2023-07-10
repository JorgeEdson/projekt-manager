using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities.Base
{

    public enum RequirementTechnique
    {
        UseCase,
        UserStory
    }
    
    public enum RequirementSize

    {
        Small,
        Medium,
        Large
    }


    public enum RequirementType
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
