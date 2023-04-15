using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Abp.Domain.Enums
{
    public enum RefListGender
    {
        [Description("Male")]
        Male = 1,
        
        [Description("Female")]
        Female = 2,

        [Description("Unkown")]
        NotDisclosed = 0
    }
}
