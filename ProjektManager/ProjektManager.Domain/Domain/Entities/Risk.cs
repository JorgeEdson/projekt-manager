﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities
{
    public class Risk : TapSession
    {
        public Risk(Tap tap, string description) : base(tap, description)
        {
        }
    }
}
