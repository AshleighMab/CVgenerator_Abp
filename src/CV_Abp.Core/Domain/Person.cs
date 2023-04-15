using Abp.Domain.Entities.Auditing;
using CV_Abp.Authorization.Users;
using CV_Abp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CV_Abp.Domain
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual RefListTitle? Title { get; set; }

        public virtual RefListRace? Race { get; set; }

        [Display(Name = "Date of Birth")]
        public virtual DateTime? DateOfBirth { get; set; }
       
        public virtual RefListGender? Gender { get; set; }

        [Display(Name = "ID/Passport Number")]
        public virtual string IdentificationNumber { get; set; }

        public virtual string CellNumber { get; set; }

        public virtual User User { get; set; }
      
      
      

    }
}
