using System.ComponentModel;
using System.Runtime.Serialization;
using FarMory.Capabilities;
using FarMory.Resources;
using Moryx.AbstractionLayer.Resources;

namespace MyApplication.Resources.MyResource
{
    [DisplayName("Green House")]
    public class GreenHouseResource : Resource
    {
        [ReferenceOverride(nameof(Children))]
        public IReferences<IGrowingSpace> GrowingSpaces { get; set; }
    }
}