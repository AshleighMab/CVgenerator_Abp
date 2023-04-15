using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Abp.Domain
{
    public class WorkExperience : FullAuditedEntity<Guid>
    {
        public virtual string Title { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
