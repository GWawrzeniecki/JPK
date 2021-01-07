using System.Collections.Generic;

namespace PrismJPKEditor.Business.Models
{
    public class Sell : BusinessBase
    {
        public override bool HasErrors => false;

        private IList<SellRow> _sellRows;
        public IList<SellRow> SellRows
        {
            get { return _sellRows; }
            set { SetProperty(ref _sellRows, value); }
        }

        private IList<SellCtrl> _sellCtrl;
        public IList<SellCtrl> SellCtrl
        {
            get { return _sellCtrl; }
            set { SetProperty(ref _sellCtrl, value); }
        }

        public Sell()
        {
            SellRows = new List<SellRow>();
            SellCtrl = new List<SellCtrl>();

        }
    }
}
