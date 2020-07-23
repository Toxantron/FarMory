using FarMory.CropManagement.Components;
using Moryx.Container;

namespace FarMory.CropManagement.Implementation
{
    [Component(LifeCycle.Singleton, typeof(IMyComponent))]
    public class Component : IMyComponent
    {
        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}