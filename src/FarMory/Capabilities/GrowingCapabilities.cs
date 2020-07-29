using Moryx.AbstractionLayer.Capabilities;

namespace FarMory.Capabilities
{
    /// <summary>
    /// Class that represents the growing requirements 
    /// </summary>
    public class GrowingCapabilities : ConcreteCapabilities
    {
        /// <summary>
        /// Required: Minimum hours of sunlight a crop needs
        /// Provided: Daily hours of sunlight at current season
        /// </summary>
        public double SunHours { get; set; }

        public SunExposure SunExposure { get; set; }

        protected override bool ProvidedBy(ICapabilities provided)
        {
            var providedGrowth = provided as GrowingCapabilities;
            // Our capabilities are only met by other instances of GrowingCapabilities
            if (providedGrowth == null)
                return false;

            // If minimum required sun hours are set, provided sun hours must be greater or equal
            if (SunHours > 0 & SunHours > providedGrowth.SunHours)
                return false; // Minimum sun hours not met

            // If possible sun exposure types are set, at least one of them must be provided
            if (SunExposure > SunExposure.Unset & !SunExposure.HasFlag(providedGrowth.SunExposure))
                return false; // Required Sun Exposure not provided

            return true;
        }
    }
}