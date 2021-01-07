using Prism.Mvvm;
using PrismJPKEditor.Core.SharedVariables;

namespace PrismJPKEditor.Modules.JPK.ViewModels
{
    public abstract class BaseViewModel<T> : BindableBase
    {

        //public ISessionContext SessionContext
        //{
        //    get; private set;
        //}

        private ISessionContext _iSessionContext;
        public virtual ISessionContext SessionContext
        {
            get { return _iSessionContext; }
            set { SetProperty(ref _iSessionContext, value); }
        }

        //private Business.Models.JPK _jpk;
        //public Business.Models.JPK JPK
        //{
        //    get { return _jpk; }
        //    set { SetProperty(ref _jpk, value); }
        //}

        //private ObservableCollection<T> _itemSource;
        //public ObservableCollection<T> ItemSource
        //{
        //    get { return _itemSource; }
        //    set { SetProperty(ref _itemSource, value); }
        //}



        public BaseViewModel(ISessionContext sessionContext)
        {
            //_itemSource = new ObservableCollection<T>();

            SessionContext = sessionContext;
        }







    }
}
