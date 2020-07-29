using System.Collections.Generic;
using Moryx.Container;
using Moryx.Serialization;

namespace FarMory
{
    public class AvailableMonthsAttribute : PrimitiveValuesAttribute
    {
        public AvailableMonthsAttribute() : base(1,2,3,4,5,6,7,8,9,10,11,12)
        {
        }
    }
}