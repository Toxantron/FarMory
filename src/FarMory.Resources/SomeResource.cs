using System.ComponentModel;
using System.Runtime.Serialization;
using FarMory.Capabilities;
using FarMory.Resources;
using Moryx.AbstractionLayer.Resources;

namespace MyApplication.Resources.MyResource
{
    [ResourceRegistration] // Only necessary for dependency injection like logging or parallel operations
    public class SomeResource : PublicResource, ISomeResource
    {
        [DataMember, EditorBrowsable]
        [Description("Configured value for the capabilities")]
        public int Value { get; set; }

        [ResourceReference(ResourceRelationType.Extension)]
        public MyResource Reference { get; set; }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            Capabilities = new SomeCapabilities{Value = Value};
        }
    }
}