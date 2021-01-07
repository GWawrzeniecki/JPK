using System.Collections.Generic;

namespace PrismJPKEditor.Business.Models
{
    public class Buy : BusinessBase
    {
        public override bool HasErrors => false;

        private IList<BuyRow> _buyRows;
        public IList<BuyRow> BuyRows
        {
            get { return _buyRows; }
            set { SetProperty(ref _buyRows, value); }
        }

        private IList<BuyCtrl> _buyCtrl;
        public IList<BuyCtrl> BuyCtrl
        {
            get { return _buyCtrl; }
            set { SetProperty(ref _buyCtrl, value); }
        }

        public Buy()
        {
            BuyRows = new List<BuyRow>();
            BuyCtrl = new List<BuyCtrl>();
        }
    }
}
