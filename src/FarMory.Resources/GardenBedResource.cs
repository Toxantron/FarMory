using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FarMory;
using FarMory.Capabilities;
using FarMory.Resources;
using Moryx.AbstractionLayer;
using Moryx.AbstractionLayer.Resources;

namespace MyApplication.Resources.MyResource
{
    [ResourceRegistration, DisplayName("Garden Bed")]
    [Description("Resource that represents a single bed")]
    public class GardenBedResource : PublicResource, IGrowingSpace
    {
        [DataMember, EditorBrowsable]
        [Description("Width of the bed")]
        public int Width { get; set; }

        [DataMember, EditorBrowsable]
        [Description("Width of the bed")]
        public int Length { get; set; }

        [DataMember, EditorBrowsable]
        [DisplayName("Sun Hours")]
        public double SunHours { get; set; }

        [DataMember, EditorBrowsable]
        public SunExposure Exposure { get; set; }

        public ProductionProcess CurrentProduction { get; set; }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            Capabilities = new GrowingCapabilities
            {
                SunHours = SunHours,
                SunExposure = Exposure
            };
        }
    }
}
