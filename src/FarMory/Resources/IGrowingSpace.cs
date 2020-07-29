using Moryx.AbstractionLayer;
using Moryx.AbstractionLayer.Resources;

namespace FarMory.Resources
{
    /// <summary>
    /// Interface for different resources that represent growing space
    /// </summary>
    public interface IGrowingSpace : IPublicResource
    {
        /// <summary>
        /// Available width
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Available length
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Current production in that growing space
        /// </summary>
        ProductionProcess CurrentProduction { get; }
    }
}