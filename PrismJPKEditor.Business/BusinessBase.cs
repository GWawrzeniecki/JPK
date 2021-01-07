using Prism.Mvvm;

namespace PrismJPKEditor.Business
{
    public abstract class BusinessBase : BindableBase, IJPK
    {
        public abstract bool HasErrors { get; }
    }
}
