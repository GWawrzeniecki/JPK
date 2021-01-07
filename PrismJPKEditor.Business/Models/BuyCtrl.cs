using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Business.Models
{
    public class BuyCtrl : BusinessBase
    {
        public override bool HasErrors => false;

        private int liczbaWierszyZakupowField;

        private decimal podatekNaliczonyField;

        /// <remarks/>
        public int LiczbaWierszyZakupow
        {
            get
            {
                return this.liczbaWierszyZakupowField;
            }
            set
            {
                SetProperty(ref liczbaWierszyZakupowField, value);               
            }
        }

        /// <remarks/>
        public decimal PodatekNaliczony
        {
            get
            {
                return this.podatekNaliczonyField;
            }
            set
            {
                SetProperty(ref podatekNaliczonyField, value);                
            }
        }
    }
}
