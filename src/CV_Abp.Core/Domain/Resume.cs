using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Abp.Domain
{
    public class Resume : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid PersonId { get; set; }
        public Person Person { get; set; }
        public List<Education> Education { get; set; }
        public List<Skill> Skill { get; set; }
        public List<WorkExperience> WorkExperience { get; set; }
        public List<Certification> Certification { get; set; }
    }
}
