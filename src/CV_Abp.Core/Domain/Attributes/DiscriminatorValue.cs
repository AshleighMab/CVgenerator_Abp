using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Abp.Domain.Attributes
{

    [AttributeUsage(AttributeTargets.Class)]
    internal class DiscriminatorValue : Attribute
    {
        public object Value { get; set; }
        public DiscriminatorValue(object value)
        {
            Value = value;
        }
    }
}
