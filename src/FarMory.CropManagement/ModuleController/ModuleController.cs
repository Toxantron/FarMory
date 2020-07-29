using FarMory.CropManagement.Components;
using FarMory.CropManagement.Facade;
using FarMory.Facade;
using FarMory.Plugins;
using Moryx.AbstractionLayer.Products;
using Moryx.AbstractionLayer.Resources;
using Moryx.Runtime.Container;
using Moryx.Runtime.Modules;

namespace FarMory.CropManagement.ModuleController
{
    [ServerModule(ModuleName)]
    public class ModuleController : ServerModuleFacadeControllerBase<ModuleConfig>, IFacadeContainer<ICropManagement>
    {
        internal const string ModuleName = "CropManager";

        public override string Name => ModuleName;

        [RequiredModuleApi(IsStartDependency = true, IsOptional = false)]
        public IResourceManagement ResourceManagement { get; set; }

        [RequiredModuleApi(IsStartDependency = true, IsOptional = false)]
        public IProductManagement ProductManagement { get; set; }

        #region State transition

        /// <summary>
        /// Code executed on start up and after service was stopped and should be started again
        /// </summary>
        protected override void OnInitialize()
        {
            // Register required facades
            Container
                .SetInstance(ResourceManagement)
                .SetInstance(ProductManagement);
            
            // Load plugins
            Container.LoadComponents<IMyModulesPlugin>();
        }

        /// <summary>
        /// Code executed after OnInitialize
        /// </summary>
        protected override void OnStart()
        {
            // Start component
            Container.Resolve<IGardenPlanner>().Start();

            ActivateFacade(_cropManagement);
        }

        /// <summary>
        /// Code executed when service is stopped
        /// </summary>
        protected override void OnStop()
        {
            DeactivateFacade(_cropManagement);

            Container.Resolve<IGardenPlanner>().Stop();
        }

        #endregion

        #region FacadeContainer


        private readonly CropManagementFacade _cropManagement = new CropManagementFacade();
        ICropManagement IFacadeContainer<ICropManagement>.Facade => _cropManagement;

        #endregion
    }
}