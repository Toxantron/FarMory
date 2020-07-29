using System;
using System.ComponentModel;
using Moryx.AbstractionLayer.Products;
using Moryx.Serialization;

namespace FarMory.Products
{
    public class CropType : ProductType
    {
        [AvailableMonths, DisplayName("Indoor Sowing")]
        [Description("Earliest month for indoor propagation")]
        public int IndoorSowing { get; set; }

        [AvailableMonths, DisplayName("Outdoor Sowing")]
        [Description("Earliest month for outdoor propagation")]
        public int OutdoorSowing { get; set; }

        [AvailableMonths, DisplayName("Last Sowing")]
        [Description("Last possible month for sowing propagation")]
        public int LastSowing { get; set; }

        [Description("Spacing within a row")]
        public int InRowSpacing { get; set; }

        [Description("Spacing between rows")]
        public int BetweenRowsSpacing { get; set; }

        [Description("Lifespan of the crop")]
        public CropLifespan Lifespan { get; set; }

        protected override ProductInstance Instantiate()
        {
            return new CropInstance();
        }
    }


}