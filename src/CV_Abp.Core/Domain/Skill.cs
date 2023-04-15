using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Abp.Domain
{
    public class Skill : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual int? ProficiencyLevel { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
