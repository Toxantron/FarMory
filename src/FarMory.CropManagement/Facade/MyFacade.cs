using System;
using FarMory.CropManagement.Components;
using FarMory.Facade;
using Moryx.Runtime.Modules;

namespace FarMory.CropManagement.Facade
{
    public class MyFacade : IFacadeControl, IMyFacade
    {
        public IMyComponent Component { get; set; }

        public void Activate()
        {
        }

        public void Deactivate()
        {
        }

        public Action ValidateHealthState { get; set; }
    }
}