using ProjektManager.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Core.Domain.Entities
{
    public class Example : BaseEntity
    {
        public int UserStoryId { get; set; }
        public UserStory UserStory { get; set; }
        public string Context { get; set; }
        public string Action { get; set; }
        public string Result { get; set; }
    }
}
