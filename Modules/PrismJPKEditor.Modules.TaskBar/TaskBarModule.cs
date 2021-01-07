using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismJPKEditor.Core;
using PrismJPKEditor.Modules.TaskBar.Views;
using PrismJPKEditor.Services;
using PrismJPKEditor.Services.Interfaces;

namespace PrismJPKEditor.Modules.TaskBar
{
    public class TaskBarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public TaskBarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(TaskBarView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IJPKService, JPKService>();
            containerRegistry.RegisterSingleton<IFileDialogService, FileDialogService>();


        }
    }
}