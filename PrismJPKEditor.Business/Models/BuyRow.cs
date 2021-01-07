using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Business.Models
{
    public class BuyRow : BusinessBase
    {
        public override bool HasErrors => false;

        private int lpZakupuField;

        private string kodKrajuNadaniaTINField;

        private string nrDostawcyField;

        private string nazwaDostawcyField;

        private string dowodZakupuField;

        private System.DateTime dataZakupuField;

        private System.DateTime? dataWplywuField;

        private string dokumentZakupuField;

        private int? mPPField;

        private int? iMPField;

        private decimal? k_40Field;

        private decimal? k_41Field;

        private decimal? k_42Field;

        private decimal? k_43Field;

        private decimal? k_44Field;

        private decimal? k_45Field;

        private decimal? k_46Field;

        private decimal? k_47Field;

        private decimal? zakupVAT_MarzaField;

        /// <remarks/>
        public int LpZakupu
        {
            get
            {
                return this.lpZakupuField;
            }
            set
            {
                SetProperty(ref lpZakupuField, value);               
            }
        }

        /// <remarks/>
        public string KodKrajuNadaniaTIN
        {
            get
            {
                return this.kodKrajuNadaniaTINField;
            }
            set
            {
                SetProperty(ref kodKrajuNadaniaTINField, value);
                
            }
        }

        /// <remarks/>
        public string NrDostawcy
        {
            get
            {
                return this.nrDostawcyField;
            }
            set
            {
                SetProperty(ref nrDostawcyField, value);

               
            }
        }

        /// <remarks/>
        public string NazwaDostawcy
        {
            get
            {
                return this.nazwaDostawcyField;
            }
            set
            {
                SetProperty(ref nazwaDostawcyField, value);

              
            }
        }

        /// <remarks/>
        public string DowodZakupu
        {
            get
            {
                return this.dowodZakupuField;
            }
            set
            {
                SetProperty(ref dowodZakupuField, value);
                
            }
        }

      
        public System.DateTime DataZakupu
        {

            get
            {
                return this.dataZakupuField;
            }
            set
            {
                SetProperty(ref dataZakupuField, value);

                
            }
        }

       
        public System.DateTime? DataWplywu
        {
            get
            {
                return this.dataWplywuField;
            }
            set
            {
                SetProperty(ref dataWplywuField, value);

                
            }
        }

        /// <remarks/>
        public string DokumentZakupu
        {
            get
            {
                return this.dokumentZakupuField;
            }
            set
            {
                SetProperty(ref dokumentZakupuField, value);

                
            }
        }

        /// <remarks/>
        public int? MPP
        {
            get
            {
                return this.mPPField;
            }
            set
            {
                SetProperty(ref mPPField, value);

                
            }
        }

        /// <remarks/>
        public int? IMP
        {
            get
            {
                return this.iMPField;
            }
            set
            {
                SetProperty(ref iMPField, value);

              
            }
        }

        /// <remarks/>
        public decimal? K_40
        {
            get
            {
                return this.k_40Field;
            }
            set
            {
                SetProperty(ref k_40Field, value);

                
            }
        }

        /// <remarks/>
        public decimal? K_41
        {
            get
            {
                return this.k_41Field;
            }
            set
            {
                SetProperty(ref k_41Field, value);

              
            }
        }

        /// <remarks/>
        public decimal? K_42
        {
            get
            {
                return this.k_42Field;
            }
            set
            {
                SetProperty(ref k_42Field, value);
               
            }
        }

        /// <remarks/>
        public decimal? K_43
        {
            get
            {
                return this.k_43Field;
            }
            set
            {
                SetProperty(ref k_43Field, value);

                
            }
        }

        /// <remarks/>
        public decimal? K_44
        {
            get
            {
                return this.k_44Field;
            }
            set
            {
                SetProperty(ref k_44Field, value);

               
            }
        }

        /// <remarks/>
        public decimal? K_45
        {
            get
            {
                return this.k_45Field;
            }
            set
            {
                SetProperty(ref k_45Field, value);

               
            }
        }

        /// <remarks/>
        public decimal? K_46
        {
            get
            {
                return this.k_46Field;
            }
            set
            {
                SetProperty(ref k_46Field, value);

               
            }
        }

        /// <remarks/>
        public decimal? K_47
        {
            get
            {
                return this.k_47Field;
            }
            set
            {
                SetProperty(ref k_47Field, value);

              
            }
        }

        /// <remarks/>
        public decimal? ZakupVAT_Marza
        {
            get
            {
                return this.zakupVAT_MarzaField;
            }
            set
            {
                SetProperty(ref zakupVAT_MarzaField, value);              
            }
        }
    }
}
