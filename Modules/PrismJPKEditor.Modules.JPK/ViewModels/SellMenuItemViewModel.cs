using MahApps.Metro.IconPacks;
using Prism.Commands;
using PrismJPKEditor.Core;

namespace PrismJPKEditor.Modules.JPK.ViewModels
{
    public class SellMenuItemViewModel : MenuItemViewModel
    {
        private readonly IApllicationCommands applicationCommands;
        

        public SellMenuItemViewModel(IApllicationCommands applicationCommands)
        {
            Label = "Sprzedaż";
            this.applicationCommands = applicationCommands;
          
            Command = new DelegateCommand(Navigate);
            Icon = new PackIconVaadinIcons() { Kind = PackIconVaadinIconsKind.Wallet };
        }

        private void Navigate()
        {
            applicationCommands.NavigateCommand.Execute(DefaultNavigationPath);          
        }

        public override string DefaultNavigationPath => "Sell";


    }
}
