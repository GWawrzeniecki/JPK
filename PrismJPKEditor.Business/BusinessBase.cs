using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Business
{
    public abstract class BusinessBase : BindableBase, IJPK
    {
        public abstract bool HasErrors { get; }
    }
}
