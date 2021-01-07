using MahApps.Metro.IconPacks;
using Prism.Commands;
using PrismJPKEditor.Core;

namespace PrismJPKEditor.Modules.JPK.ViewModels
{
    public class DeclarationMenuItemViewModel : MenuItemViewModel
    {
        private readonly IApllicationCommands applicationCommands;
       

        public DeclarationMenuItemViewModel(IApllicationCommands applicationCommands)
        {
            Label = "Deklaracja";
            this.applicationCommands = applicationCommands;          
            Command = new DelegateCommand(Navigate);
            Icon = new PackIconMaterialDesign() { Kind = PackIconMaterialDesignKind.Assignment };
        }

        private void Navigate()
        {
            applicationCommands.NavigateCommand.Execute(DefaultNavigationPath);                      
        }

        public override string DefaultNavigationPath => "Declaration";
    }
}
