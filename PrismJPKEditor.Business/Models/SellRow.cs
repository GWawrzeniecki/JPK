using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PrismJPKEditor.Business.Models
{
    public class SellRow : BusinessBase
    {


        #region private members

        private int lpSprzedazyField;

        private string kodKrajuNadaniaTINField;

        private string nrKontrahentaField;

        private string nazwaKontrahentaField;

        private string dowodSprzedazyField;

        private DateTime? dataWystawieniaField;

        private DateTime? dataSprzedazyField;

        private string typDokumentuField;

        private int? gTU_01Field;

        private int? gTU_02Field;

        private int? gTU_03Field;

        private int? gTU_04Field;

        private int? gTU_05Field;

        private int? gTU_06Field;

        private int? gTU_07Field;

        private int? gTU_08Field;

        private int? gTU_09Field;

        private int? gTU_10Field;

        private int? gTU_11Field;

        private int? gTU_12Field;

        private int? gTU_13Field;

        private int? swField;

        private int? eeField;

        private int? tpField;

        private int? tT_WNTField;

        private int? tT_DField;

        private int? mR_TField;

        private int? mR_UZField;

        private int? i_42Field;

        private int? i_63Field;

        private int? b_SPVField;

        private int? b_SPV_DOSTAWAField;

        private int? b_MPV_PROWIZJAField;

        private int? mPPField;

        private int? korektaPodstawyOpodtField;

        private decimal? k_10Field;

        private decimal? k_11Field;

        private decimal? k_12Field;

        private decimal? k_13Field;

        private decimal? k_14Field;

        private decimal? k_15Field;

        private decimal? k_16Field;

        private decimal? k_17Field;

        private decimal? k_18Field;

        private decimal? k_19Field;

        private decimal? k_20Field;

        private decimal? k_21Field;

        private decimal? k_22Field;

        private decimal? k_23Field;

        private decimal? k_24Field;

        private decimal? k_25Field;

        private decimal? k_26Field;

        private decimal? k_27Field;

        private decimal? k_28Field;

        private decimal? k_29Field;

        private decimal? k_30Field;

        private decimal? k_31Field;

        private decimal? k_32Field;

        private decimal? k_33Field;

        private decimal? k_34Field;

        private decimal? k_35Field;

        private decimal? k_36Field;

        private decimal? sprzedazVAT_MarzaField;

        #endregion

        #region public properties

        public Sell Sell { get; set; }
        /// <remarks/>
        public int LpSprzedazy
        {
            get
            {
                return this.lpSprzedazyField;
            }
            set
            {
                SetProperty(ref lpSprzedazyField, value);

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
        public string NrKontrahenta
        {
            get
            {
                return this.nrKontrahentaField;
            }
            set
            {
                SetProperty(ref nrKontrahentaField, value);
            }
        }

        /// <remarks/>
        public string NazwaKontrahenta
        {
            get
            {
                return this.nazwaKontrahentaField;
            }
            set
            {
                SetProperty(ref nazwaKontrahentaField, value);
            }
        }

        /// <remarks/>
        public string DowodSprzedazy
        {
            get
            {
                return this.dowodSprzedazyField;
            }
            set
            {
                SetProperty(ref dowodSprzedazyField, value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public DateTime? DataWystawienia
        {
            get
            {
                return this.dataWystawieniaField;
            }
            set
            {
                SetProperty(ref dataWystawieniaField, value);


            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public DateTime? DataSprzedazy
        {
            get
            {
                return this.dataSprzedazyField;
            }
            set
            {
                SetProperty(ref dataSprzedazyField, value);

            }
        }

        /// <remarks/>
        public string TypDokumentu
        {
            get
            {
                return this.typDokumentuField;
            }
            set
            {
                SetProperty(ref typDokumentuField, value);


            }
        }

        /// <remarks/>
        public int? GTU_01
        {
            get
            {
                return this.gTU_01Field;
            }
            set
            {
                SetProperty(ref gTU_01Field, value);

            }
        }

        /// <remarks/>
        public int? GTU_02
        {
            get
            {
                return this.gTU_02Field;
            }
            set
            {
                SetProperty(ref gTU_02Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_03
        {
            get
            {
                return this.gTU_03Field;
            }
            set
            {
                SetProperty(ref gTU_03Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_04
        {
            get
            {
                return this.gTU_04Field;
            }
            set
            {
                SetProperty(ref gTU_04Field, value);

            }
        }

        /// <remarks/>
        public int? GTU_05
        {
            get
            {
                return this.gTU_05Field;
            }
            set
            {
                SetProperty(ref gTU_05Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_06
        {
            get
            {
                return this.gTU_06Field;
            }
            set
            {
                SetProperty(ref gTU_06Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_07
        {
            get
            {
                return this.gTU_07Field;
            }
            set
            {
                SetProperty(ref gTU_07Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_08
        {
            get
            {
                return this.gTU_08Field;
            }
            set
            {
                SetProperty(ref gTU_08Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_09
        {
            get
            {
                return this.gTU_09Field;
            }
            set
            {
                SetProperty(ref gTU_09Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_10
        {
            get
            {
                return this.gTU_10Field;
            }
            set
            {
                SetProperty(ref gTU_10Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_11
        {
            get
            {
                return this.gTU_11Field;
            }
            set
            {
                SetProperty(ref gTU_11Field, value);

            }
        }

        /// <remarks/>
        public int? GTU_12
        {
            get
            {
                return this.gTU_12Field;
            }
            set
            {
                SetProperty(ref gTU_12Field, value);


            }
        }

        /// <remarks/>
        public int? GTU_13
        {
            get
            {
                return this.gTU_13Field;
            }
            set
            {
                SetProperty(ref gTU_13Field, value);

            }
        }

        /// <remarks/>
        public int? SW
        {
            get
            {
                return this.swField;
            }
            set
            {
                SetProperty(ref swField, value);


            }
        }

        /// <remarks/>
        public int? EE
        {
            get
            {
                return this.eeField;
            }
            set
            {
                SetProperty(ref eeField, value);


            }
        }

        /// <remarks/>
        public int? TP
        {
            get
            {
                return this.tpField;
            }
            set
            {
                SetProperty(ref tpField, value);


            }
        }

        /// <remarks/>
        public int? TT_WNT
        {
            get
            {
                return this.tT_WNTField;
            }
            set
            {
                SetProperty(ref tT_WNTField, value);


            }
        }

        /// <remarks/>
        public int? TT_D
        {
            get
            {
                return this.tT_DField;
            }
            set
            {
                SetProperty(ref tT_DField, value);


            }
        }

        /// <remarks/>
        public int? MR_T
        {
            get
            {
                return this.mR_TField;
            }
            set
            {
                SetProperty(ref mR_TField, value);


            }
        }

        /// <remarks/>
        public int? MR_UZ
        {
            get
            {
                return this.mR_UZField;
            }
            set
            {
                SetProperty(ref mR_UZField, value);

            }
        }

        /// <remarks/>
        public int? I_42
        {
            get
            {
                return this.i_42Field;
            }
            set
            {
                SetProperty(ref i_42Field, value);

            }
        }

        /// <remarks/>
        public int? I_63
        {
            get
            {
                return this.i_63Field;
            }
            set
            {
                SetProperty(ref i_63Field, value);

            }
        }

        /// <remarks/>
        public int? B_SPV
        {
            get
            {
                return this.b_SPVField;
            }
            set
            {
                SetProperty(ref b_SPVField, value);


            }
        }

        /// <remarks/>
        public int? B_SPV_DOSTAWA
        {
            get
            {
                return this.b_SPV_DOSTAWAField;
            }
            set
            {
                SetProperty(ref b_SPV_DOSTAWAField, value);


            }
        }

        /// <remarks/>
        public int? B_MPV_PROWIZJA
        {
            get
            {
                return this.b_MPV_PROWIZJAField;
            }
            set
            {
                SetProperty(ref b_MPV_PROWIZJAField, value);


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
        public int? KorektaPodstawyOpodt
        {
            get
            {
                return this.korektaPodstawyOpodtField;
            }
            set
            {
                SetProperty(ref korektaPodstawyOpodtField, value);

            }
        }

        /// <remarks/>
        public decimal? K_10
        {
            get
            {
                return this.k_10Field;
            }
            set
            {
                SetProperty(ref k_10Field, value);

            }
        }

        /// <remarks/>
        public decimal? K_11
        {
            get
            {
                return this.k_11Field;
            }
            set
            {
                SetProperty(ref k_11Field, value);

            }
        }

        /// <remarks/>
        public decimal? K_12
        {
            get
            {
                return this.k_12Field;
            }
            set
            {
                SetProperty(ref k_12Field, value);

            }
        }

        /// <remarks/>
        public decimal? K_13
        {
            get
            {
                return this.k_13Field;
            }
            set
            {
                SetProperty(ref k_13Field, value);

            }
        }

        /// <remarks/>
        public decimal? K_14
        {
            get
            {
                return this.k_14Field;
            }
            set
            {
                SetProperty(ref k_14Field, value);

            }
        }

        /// <remarks/>
        public decimal? K_15
        {
            get
            {
                return this.k_15Field;
            }
            set
            {
                SetProperty(ref k_15Field, value);


            }
        }

        /// <remarks/>
        public decimal? K_16
        {
            get
            {
                return this.k_16Field;
            }
            set
            {
                SetProperty(ref k_16Field, value);
                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT



            }
        }

        /// <remarks/>
        public decimal? K_17
        {
            get
            {
                return this.k_17Field;
            }
            set
            {
                SetProperty(ref k_17Field, value);


            }
        }

        /// <remarks/>
        public decimal? K_18
        {
            get
            {
                return this.k_18Field;
            }
            set
            {
              

                SetProperty(ref k_18Field, value);
                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? K_19
        {
            get
            {
                return this.k_19Field;
            }
            set
            {
                SetProperty(ref k_19Field, value);

            }
        }

        /// <remarks/>
        public decimal? K_20
        {
            get
            {
                return this.k_20Field;
            }
            set
            {
              

                SetProperty(ref k_20Field, value);
                Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? K_21
        {
            get
            {
                return this.k_21Field;
            }
            set
            {
                SetProperty(ref k_21Field, value);


            }
        }

        /// <remarks/>
        public decimal? K_22
        {
            get
            {
                return this.k_22Field;
            }
            set
            {
                SetProperty(ref k_22Field, value);


            }
        }

        /// <remarks/>
        public decimal? K_23
        {
            get
            {
                return this.k_23Field;
            }
            set
            {
                SetProperty(ref k_23Field, value);


            }
        }

        /// <remarks/>
        public decimal? K_24
        {
            get
            {
                return this.k_24Field;
            }
            set
            {
               

                SetProperty(ref k_24Field, value);
                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT

            }
        }

        /// <remarks/>
        public decimal? K_25
        {
            get
            {
                return this.k_25Field;
            }
            set
            {
                SetProperty(ref k_25Field, value);

            }
        }

        /// <remarks/>
        public decimal? K_26
        {
            get
            {
                return this.k_26Field;
            }
            set
            {
                

                SetProperty(ref k_26Field, value);

                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? K_27
        {
            get
            {
                return this.k_27Field;
            }
            set
            {
                SetProperty(ref k_27Field, value);

            }
        }

        /// <remarks/>
        public decimal? K_28
        {
            get
            {
                return this.k_28Field;
            }
            set
            {
               

                SetProperty(ref k_28Field, value);

                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? K_29
        {
            get
            {
                return this.k_29Field;
            }
            set
            {
                SetProperty(ref k_29Field, value);


            }
        }

        /// <remarks/>
        public decimal? K_30
        {
            get
            {
                return this.k_30Field;
            }
            set
            {
               
                SetProperty(ref k_30Field, value);

                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT

            }
        }

        /// <remarks/>
        public decimal? K_31
        {
            get
            {
                return this.k_31Field;
            }
            set
            {
                SetProperty(ref k_31Field, value);


            }
        }

        /// <remarks/>
        public decimal? K_32
        {
            get
            {
                return this.k_32Field;
            }
            set
            {
              

                SetProperty(ref k_32Field, value);

                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? K_33
        {
            get
            {
                return this.k_33Field;
            }
            set
            {
             

                SetProperty(ref k_33Field, value);

                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? K_34
        {
            get
            {
                return this.k_34Field;
            }
            set
            {
               

                SetProperty(ref k_34Field, value);
                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? K_35
        {
            get
            {
                return this.k_35Field;
            }
            set
            {
               

                SetProperty(ref k_35Field, value);

                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? K_36
        {
            get
            {
                return this.k_36Field;
            }
            set
            {
              
                SetProperty(ref k_36Field, value);
                 Sell?.SellCtrl?.FirstOrDefault()?.ValidatePodatekNalezny(); // TO DO CHANGE IT
            }
        }

        /// <remarks/>
        public decimal? SprzedazVAT_Marza
        {
            get
            {
                return this.sprzedazVAT_MarzaField;
            }
            set
            {
                SetProperty(ref sprzedazVAT_MarzaField, value);

            }
        }

        public override bool HasErrors => false;

        #endregion





    }
}
