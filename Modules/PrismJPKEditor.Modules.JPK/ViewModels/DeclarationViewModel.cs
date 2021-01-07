using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismJPKEditor.Business.Models;
using PrismJPKEditor.Core;
using PrismJPKEditor.Core.SharedVariables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrismJPKEditor.Modules.JPK.ViewModels
{
    public class DeclarationViewModel : BaseViewModel<Declaration>
    {
        
        
        public DeclarationViewModel(ISessionContext sessionContext) : base(sessionContext)
        {
            
        }

        
    }
}
