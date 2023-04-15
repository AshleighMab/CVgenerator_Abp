using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Abp.Domain
{
    public class Education : FullAuditedEntity<Guid>
    {
        public virtual string Degree { get; set; }
        public virtual string SchoolName { get; set; }
        public virtual DateTime? GraduationDate { get; set; }
        public virtual string Major { get; set; }
        public virtual Guid ResumeId { get; set; }
        public Resume Resume { get; set; }

    }
}
