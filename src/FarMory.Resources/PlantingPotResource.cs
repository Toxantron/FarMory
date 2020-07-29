using System.ComponentModel;
using FarMory.Resources;
using Moryx.AbstractionLayer;
using Moryx.AbstractionLayer.Resources;

namespace MyApplication.Resources.MyResource
{
    [ResourceRegistration, DisplayName("Planting Pot")]
    [Description("Resource that represents a pot for growing plants")]
    public class PlantingPotResource : PublicResource, IGrowingSpace
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public ProductionProcess CurrentProduction { get; set; }
    }
}