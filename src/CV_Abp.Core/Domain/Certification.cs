using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Abp.Domain
{
    public class Certification : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string IssuingOrganization { get; set; }
        public virtual DateTime? CertificationDate { get; set; }
        public virtual Guid ResumeId { get; set; }
        public Resume Resume { get; set; }

    }
}
