using MahApps.Metro.IconPacks;
using Prism.Commands;
using PrismJPKEditor.Core;

namespace PrismJPKEditor.Modules.JPK.ViewModels
{
    public class BuyMenuItemViewModel : MenuItemViewModel
    {
        private readonly IApllicationCommands applicationCommands;



        public BuyMenuItemViewModel(IApllicationCommands applicationCommands)
        {
            Label = "Zakup";
            this.applicationCommands = applicationCommands;
            Command = new DelegateCommand(Navigate);
            Icon = new PackIconVaadinIcons() { Kind = PackIconVaadinIconsKind.Cart };
        }

        private void Navigate()
        {
            applicationCommands.NavigateCommand.Execute(DefaultNavigationPath);
        }

        public override string DefaultNavigationPath => "Buy";


    }
}
