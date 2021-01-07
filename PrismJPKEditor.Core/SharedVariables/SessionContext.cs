using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismJPKEditor.Core.SharedVariables
{
    public class SessionContext : BindableBase, ISessionContext
    {

        private Business.Models.JPK _jpkDataSource;
        public Business.Models.JPK JPKDataSource
        {
            get { return _jpkDataSource; }
            set
            {
                SetProperty(ref _jpkDataSource, value);
                //JPKDataSource.Declaration.Declarations.ToList().ForEach(df => df.ValidateDoublePair()); // Juz niepotrzebne
            }
        }

        public bool HasErrors => JPKDataSource.Declaration.HasErrors || JPKDataSource.Buy.HasErrors || JPKDataSource.Sell.HasErrors;

        public SessionContext()
        {
            JPKDataSource = new Business.Models.JPK
            {
                Declaration = new Business.Models.Declaration(),
                Buy = new Business.Models.Buy(),
                Sell = new Business.Models.Sell()
            };

            // test
        }

    }

}
