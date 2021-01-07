using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using PrismJPKEditor.Core;
using PrismJPKEditor.Modules.JPK.ViewModels;
using PrismJPKEditor.Modules.JPK.Views;
using PrismJPKEditor.Services;
using PrismJPKEditor.Services.Interfaces;

namespace PrismJPKEditor.Modules.JPK
{
    public class JPKModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public JPKModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.HamburgerMenuRegion, typeof(DeclarationMenuItemViewModel));
            _regionManager.RegisterViewWithRegion(RegionNames.HamburgerMenuRegion, typeof(SellMenuItemViewModel));
            _regionManager.RegisterViewWithRegion(RegionNames.HamburgerMenuRegion, typeof(BuyMenuItemViewModel));
        }



        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Declaration, DeclarationViewModel>();
            containerRegistry.RegisterForNavigation<Buy, BuyViewModel>();
            containerRegistry.RegisterForNavigation<Sell, SellViewModel>();
        }
    }
}