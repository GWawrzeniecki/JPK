using MahApps.Metro.Controls;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Modules.JPK.ViewModels
{
    public class MenuItemViewModel : HamburgerMenuIconItem, Core.IHamburgerMenuItem
    {
        public virtual string DefaultNavigationPath { get;}
      //  public string Label { get; set; }
    }
}
