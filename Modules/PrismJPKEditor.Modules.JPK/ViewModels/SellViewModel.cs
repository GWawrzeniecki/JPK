using MahApps.Metro.IconPacks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismJPKEditor.Business.Models;
using PrismJPKEditor.Core;
using PrismJPKEditor.Core.SharedVariables;
using PrismJPKEditor.Modules.JPK.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;


namespace PrismJPKEditor.Modules.JPK.ViewModels
{
    public class SellViewModel : BaseViewModel<Sell>
    {
        

      

        public SellViewModel(ISessionContext sessionContext) : base(sessionContext)
        {
           
        }

        

    }
}
