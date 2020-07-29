using FarMory.CropManagement.Components;
using Moryx.Container;

namespace FarMory.CropManagement.Implementation
{
    [Component(LifeCycle.Singleton, typeof(IGardenPlanner))]
    public class GardenPlanner : IGardenPlanner
    {
        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}