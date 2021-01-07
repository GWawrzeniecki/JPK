using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismJPKEditor.Core;
using PrismJPKEditor.Modules.JPK.ViewModels;
using System;

namespace PrismJPKEditor.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        private string _title = "JPK Edytor";
        private DelegateCommand<string> _navigateCommand;
        private DelegateCommand _windowLoaded;    
        private IRegionManager _regionManager;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private MenuItemViewModel _selectedHamburgerMenuItem;
       

        public MenuItemViewModel SelectedHamburgerMenuItem
        {
            get { return _selectedHamburgerMenuItem; }
            set { SetProperty(ref _selectedHamburgerMenuItem, value); }
        }

        public DelegateCommand<string> NavigateCommand =>
_navigateCommand ??= new DelegateCommand<string>(ExecuteNavigateCommand);


        public DelegateCommand WindowLoaded =>
_windowLoaded ??= new DelegateCommand(WindowdLoaded);
        

        private void WindowdLoaded()
        {
            ExecuteNavigateCommand("Declaration");
        }

       

        public MainWindowViewModel(IRegionManager regionManager, IApllicationCommands apllicationCommands)
        {
            _regionManager = regionManager;
            apllicationCommands.NavigateCommand.RegisterCommand(NavigateCommand);
            
        }

        #region privateMethods

        private void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
                throw new ArgumentNullException();

            _regionManager.RequestNavigate(RegionNames.ContentRegion, navigationPath);
        }

        #endregion
    }
}
