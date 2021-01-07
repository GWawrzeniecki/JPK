using MahApps.Metro.Controls;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismJPKEditor.Core;
using PrismJPKEditor.Core.Regions;
using PrismJPKEditor.Modules.JPK;
using PrismJPKEditor.Modules.TaskBar;
using PrismJPKEditor.Views;
using System.Windows;

namespace PrismJPKEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell(Window shell)

        {
            base.InitializeShell(shell);
           
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            containerRegistry.RegisterSingleton<IApllicationCommands, ApplicationCommands>();
            containerRegistry.RegisterSingleton<Core.SharedVariables.ISessionContext, Core.SharedVariables.SessionContext>();
            containerRegistry.RegisterDialog<NotificationDialog>(DialogNames.NotificationDialog);
            containerRegistry.RegisterDialog<YesNoDialog>(DialogNames.YesNoDialog);
            containerRegistry.RegisterDialogWindow<MahappsDialogWindow>();
        }


        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<JPKModule>();
            moduleCatalog.AddModule<TaskBarModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(HamburgerMenuItemCollection), Container.Resolve<HamburgerMenuItemCollectionRegionAdapter>());
            
        }
    }
}
