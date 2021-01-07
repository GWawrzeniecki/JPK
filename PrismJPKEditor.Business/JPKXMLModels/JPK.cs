using System;
using System.Xml.Serialization;

namespace PrismJPKEditor.Business.JPKXMLModels
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/", IsNullable = false)]
    public partial class JPK
    {

        private JPKNaglowek naglowekField;

        private JPKPodmiot1 podmiot1Field;

        private JPKDeklaracja deklaracjaField;

        private JPKEwidencja ewidencjaField;

        /// <remarks/>
        public JPKNaglowek Naglowek
        {
            get
            {
                return this.naglowekField;
            }
            set
            {
                this.naglowekField = value;
            }
        }

        /// <remarks/>
        public JPKPodmiot1 Podmiot1
        {
            get
            {
                return this.podmiot1Field;
            }
            set
            {
                this.podmiot1Field = value;
            }
        }

        /// <remarks/>
        public JPKDeklaracja Deklaracja
        {
            get
            {
                return this.deklaracjaField;
            }
            set
            {
                this.deklaracjaField = value;
            }
        }

        /// <remarks/>
        public JPKEwidencja Ewidencja
        {
            get
            {
                return this.ewidencjaField;
            }
            set
            {
                this.ewidencjaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKNaglowek
    {

        private JPKNaglowekKodFormularza kodFormularzaField;

        private byte wariantFormularzaField;

        private System.DateTime dataWytworzeniaJPKField;

        private string nazwaSystemuField;

        private JPKNaglowekCelZlozenia celZlozeniaField;

        private ushort kodUrzeduField;

        private ushort rokField;

        private byte miesiacField;

        /// <remarks/>
        public JPKNaglowekKodFormularza KodFormularza
        {
            get
            {
                return this.kodFormularzaField;
            }
            set
            {
                this.kodFormularzaField = value;
            }
        }

        /// <remarks/>
        public byte WariantFormularza
        {
            get
            {
                return this.wariantFormularzaField;
            }
            set
            {
                this.wariantFormularzaField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DataWytworzeniaJPK
        {
            get
            {
                return this.dataWytworzeniaJPKField;
            }
            set
            {
                this.dataWytworzeniaJPKField = value;
            }
        }

        /// <remarks/>
        public string NazwaSystemu
        {
            get
            {
                return this.nazwaSystemuField;
            }
            set
            {
                this.nazwaSystemuField = value;
            }
        }

        /// <remarks/>
        public JPKNaglowekCelZlozenia CelZlozenia
        {
            get
            {
                return this.celZlozeniaField;
            }
            set
            {
                this.celZlozeniaField = value;
            }
        }

        /// <remarks/>
        public ushort KodUrzedu
        {
            get
            {
                return this.kodUrzeduField;
            }
            set
            {
                this.kodUrzeduField = value;
            }
        }

        /// <remarks/>
        public ushort Rok
        {
            get
            {
                return this.rokField;
            }
            set
            {
                this.rokField = value;
            }
        }

        /// <remarks/>
        public byte Miesiac
        {
            get
            {
                return this.miesiacField;
            }
            set
            {
                this.miesiacField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKNaglowekKodFormularza
    {

        private string wersjaSchemyField;

        private string kodSystemowyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wersjaSchemy
        {
            get
            {
                return this.wersjaSchemyField;
            }
            set
            {
                this.wersjaSchemyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kodSystemowy
        {
            get
            {
                return this.kodSystemowyField;
            }
            set
            {
                this.kodSystemowyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKNaglowekCelZlozenia
    {

        private string pozField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string poz
        {
            get
            {
                return this.pozField;
            }
            set
            {
                this.pozField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKPodmiot1
    {

        private JPKPodmiot1OsobaNiefizyczna osobaNiefizycznaField;

        private string rolaField;

        /// <remarks/>
        public JPKPodmiot1OsobaNiefizyczna OsobaNiefizyczna
        {
            get
            {
                return this.osobaNiefizycznaField;
            }
            set
            {
                this.osobaNiefizycznaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rola
        {
            get
            {
                return this.rolaField;
            }
            set
            {
                this.rolaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKPodmiot1OsobaNiefizyczna
    {

        private ulong nIPField;

        private string pelnaNazwaField;

        private string emailField;

        private string telefonField;

        /// <remarks/>
        public ulong NIP
        {
            get
            {
                return this.nIPField;
            }
            set
            {
                this.nIPField = value;
            }
        }

        /// <remarks/>
        public string PelnaNazwa
        {
            get
            {
                return this.pelnaNazwaField;
            }
            set
            {
                this.pelnaNazwaField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string Telefon
        {
            get
            {
                return this.telefonField;
            }
            set
            {
                this.telefonField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKDeklaracja
    {

        private JPKDeklaracjaNaglowek naglowekField;

        private JPKDeklaracjaPozycjeSzczegolowe pozycjeSzczegoloweField;

        private byte pouczeniaField;

        /// <remarks/>
        public JPKDeklaracjaNaglowek Naglowek
        {
            get
            {
                return this.naglowekField;
            }
            set
            {
                this.naglowekField = value;
            }
        }

        /// <remarks/>
        public JPKDeklaracjaPozycjeSzczegolowe PozycjeSzczegolowe
        {
            get
            {
                return this.pozycjeSzczegoloweField;
            }
            set
            {
                this.pozycjeSzczegoloweField = value;
            }
        }

        /// <remarks/>
        public byte Pouczenia
        {
            get
            {
                return this.pouczeniaField;
            }
            set
            {
                this.pouczeniaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKDeklaracjaNaglowek
    {

        private JPKDeklaracjaNaglowekKodFormularzaDekl kodFormularzaDeklField;

        private byte wariantFormularzaDeklField;

        /// <remarks/>
        public JPKDeklaracjaNaglowekKodFormularzaDekl KodFormularzaDekl
        {
            get
            {
                return this.kodFormularzaDeklField;
            }
            set
            {
                this.kodFormularzaDeklField = value;
            }
        }

        /// <remarks/>
        public byte WariantFormularzaDekl
        {
            get
            {
                return this.wariantFormularzaDeklField;
            }
            set
            {
                this.wariantFormularzaDeklField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKDeklaracjaNaglowekKodFormularzaDekl
    {

        private string kodSystemowyField;

        private string wersjaSchemyField;

        private string rodzajZobowiazaniaField;

        private string kodPodatkuField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kodSystemowy
        {
            get
            {
                return this.kodSystemowyField;
            }
            set
            {
                this.kodSystemowyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wersjaSchemy
        {
            get
            {
                return this.wersjaSchemyField;
            }
            set
            {
                this.wersjaSchemyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rodzajZobowiazania
        {
            get
            {
                return this.rodzajZobowiazaniaField;
            }
            set
            {
                this.rodzajZobowiazaniaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kodPodatku
        {
            get
            {
                return this.kodPodatkuField;
            }
            set
            {
                this.kodPodatkuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKDeklaracjaPozycjeSzczegolowe
    {
        private int? p_10Field;
        
        private int? p_11Field;

        private int? p_12Field;

        private int? p_13Field;

        private int? p_14Field;

        private int? p_15Field;

        private int? p_16Field;

        private int? p_17Field;

        private int? p_18Field;

        private int? p_19Field;

        private int? p_20Field;

        private int? p_21Field;

        private int? p_22Field;

        private int? p_23Field;

        private int? p_24Field;

        private int? p_25Field;

        private int? p_26Field;

        private int? p_27Field;

        private int? p_28Field;

        private int? p_29Field;

        private int? p_30Field;

        private int? p_31Field;

        private int? p_32Field;

        private int? p_33Field;

        private int? p_34Field;

        private int? p_35Field;

        private int? p_36Field;

        private int? p_37Field;

        private int? p_38Field;

        private int? p_39Field;

        private int? p_40Field;

        private int? p_41Field;

        private int? p_42Field;

        private int? p_43Field;

        private int? p_44Field;

        private int? p_45Field;

        private int? p_46Field;

        private int? p_47Field;

        private int? p_48Field;

        private int? p_49Field;

        private int? p_50Field;

        private int? p_51Field;

        private int? p_52Field;

        private int? p_53Field;

        private int? p_54Field;

        private int? p_55Field;

        private int? p_56Field;

        private int? p_57Field;

        private int? p_58Field;

        private int? p_59Field;

        private int? p_60Field;

        private int? p_61Field;

        private int? p_62Field;

        private int? p_63Field;

        private int? p_64Field;

        private int? p_65Field;

        private int? p_66Field;

        private int? p_67Field;

        private int? p_68Field;

        private int? p_69Field;
        private string p_ORDZUField;


        public int? P_10 { get => p_10Field; set => p_10Field = value; }

        /// <remarks/>
        public int? P_11
        {
            get
            {
                return this.p_11Field;
            }
            set
            {
                this.p_11Field = value;
            }
        }

        public int? P_12 { get => p_12Field; set => p_12Field = value; }


        /// <remarks/>
        public int? P_13
        {
            get
            {
                return this.p_13Field;
            }
            set
            {
                this.p_13Field = value;
            }
        }

        public int? P_14 { get => p_14Field; set => p_14Field = value; }

        /// <remarks/>
        public int? P_15
        {
            get
            {
                return this.p_15Field;
            }
            set
            {
                this.p_15Field = value;
            }
        }

        /// <remarks/>
        public int? P_16
        {
            get
            {
                return this.p_16Field;
            }
            set
            {
                this.p_16Field = value;
            }
        }

        /// <remarks/>
        public int? P_17
        {
            get
            {
                return this.p_17Field;
            }
            set
            {
                this.p_17Field = value;
            }
        }

        /// <remarks/>
        public int? P_18
        {
            get
            {
                return this.p_18Field;
            }
            set
            {
                this.p_18Field = value;
            }
        }

        /// <remarks/>
        public int? P_19
        {
            get
            {
                return this.p_19Field;
            }
            set
            {
                this.p_19Field = value;
            }
        }

        /// <remarks/>
        public int? P_20
        {
            get
            {
                return this.p_20Field;
            }
            set
            {
                this.p_20Field = value;
            }
        }

        /// <remarks/>
        public int? P_21
        {
            get
            {
                return this.p_21Field;
            }
            set
            {
                this.p_21Field = value;
            }
        }

        /// <remarks/>
        public int? P_22
        {
            get
            {
                return this.p_22Field;
            }
            set
            {
                this.p_22Field = value;
            }
        }

        /// <remarks/>
        public int? P_23
        {
            get
            {
                return this.p_23Field;
            }
            set
            {
                this.p_23Field = value;
            }
        }

        /// <remarks/>
        public int? P_24
        {
            get
            {
                return this.p_24Field;
            }
            set
            {
                this.p_24Field = value;
            }
        }

        /// <remarks/>
        public int? P_25
        {
            get
            {
                return this.p_25Field;
            }
            set
            {
                this.p_25Field = value;
            }
        }

        /// <remarks/>
        public int? P_26
        {
            get
            {
                return this.p_26Field;
            }
            set
            {
                this.p_26Field = value;
            }
        }

        /// <remarks/>
        public int? P_27
        {
            get
            {
                return this.p_27Field;
            }
            set
            {
                this.p_27Field = value;
            }
        }

        /// <remarks/>
        public int? P_28
        {
            get
            {
                return this.p_28Field;
            }
            set
            {
                this.p_28Field = value;
            }
        }

        /// <remarks/>
        public int? P_29
        {
            get
            {
                return this.p_29Field;
            }
            set
            {
                this.p_29Field = value;
            }
        }

        /// <remarks/>
        public int? P_30
        {
            get
            {
                return this.p_30Field;
            }
            set
            {
                this.p_30Field = value;
            }
        }

        /// <remarks/>
        public int? P_31
        {
            get
            {
                return this.p_31Field;
            }
            set
            {
                this.p_31Field = value;
            }
        }

        /// <remarks/>
        public int? P_32
        {
            get
            {
                return this.p_32Field;
            }
            set
            {
                this.p_32Field = value;
            }
        }

        public int? P_33 { get => p_33Field; set => p_33Field = value; }
        public int? P_34 { get => p_34Field; set => p_34Field = value; }
        public int? P_35 { get => p_35Field; set => p_35Field = value; }
        public int? P_36 { get => p_36Field; set => p_36Field = value; }

        /// <remarks/>
        public int? P_37
        {
            get
            {
                return this.p_37Field;
            }
            set
            {
                this.p_37Field = value;
            }
        }

        /// <remarks/>
        public int? P_38
        {
            get
            {
                return this.p_38Field;
            }
            set
            {
                this.p_38Field = value;
            }
        }

        public int? P_39 { get => p_39Field; set => p_39Field = value; }


        /// <remarks/>
        public int? P_40
        {
            get
            {
                return this.p_40Field;
            }
            set
            {
                this.p_40Field = value;
            }
        }

        /// <remarks/>
        public int? P_41
        {
            get
            {
                return this.p_41Field;
            }
            set
            {
                this.p_41Field = value;
            }
        }

        /// <remarks/>
        public int? P_42
        {
            get
            {
                return this.p_42Field;
            }
            set
            {
                this.p_42Field = value;
            }
        }

        /// <remarks/>
        public int? P_43
        {
            get
            {
                return this.p_43Field;
            }
            set
            {
                this.p_43Field = value;
            }
        }

        public int? P_44 { get => p_44Field; set => p_44Field = value; }
        public int? P_45 { get => p_45Field; set => p_45Field = value; }
        public int? P_46 { get => p_46Field; set => p_46Field = value; }
        public int? P_47 { get => p_47Field; set => p_47Field = value; }

        /// <remarks/>
        public int? P_48
        {
            get
            {
                return this.p_48Field;
            }
            set
            {
                this.p_48Field = value;
            }
        }

        public int? P_49 { get => p_49Field; set => p_49Field = value; }
        public int? P_50 { get => p_50Field; set => p_50Field = value; }


        /// <remarks/>
        public int? P_51
        {
            get
            {
                return this.p_51Field;
            }
            set
            {
                this.p_51Field = value;
            }
        }



        public int? P_52 { get => p_52Field; set => p_52Field = value; }
        public int? P_53 { get => p_53Field; set => p_53Field = value; }
        public int? P_54 { get => p_54Field; set => p_54Field = value; }
        public int? P_55 { get => p_55Field; set => p_55Field = value; }
        public int? P_56 { get => p_56Field; set => p_56Field = value; }
        public int? P_57 { get => p_57Field; set => p_57Field = value; }
        public int? P_58 { get => p_58Field; set => p_58Field = value; }
        public int? P_59 { get => p_59Field; set => p_59Field = value; }
        public int? P_60 { get => p_60Field; set => p_60Field = value; }
        public int? P_61 { get => p_61Field; set => p_61Field = value; }
        public int? P_62 { get => p_62Field; set => p_62Field = value; }
        public int? P_63 { get => p_63Field; set => p_63Field = value; }
        public int? P_64 { get => p_64Field; set => p_64Field = value; }
        public int? P_65 { get => p_65Field; set => p_65Field = value; }
        public int? P_66 { get => p_66Field; set => p_66Field = value; }
        public int? P_67 { get => p_67Field; set => p_67Field = value; }
        public int? P_68 { get => p_68Field; set => p_68Field = value; }
        public int? P_69 { get => p_69Field; set => p_69Field = value; }

        public string P_ORDZU
        {
            get
            {
                return this.p_ORDZUField;
            }
            set
            {
                this.p_ORDZUField = value;
            }
        }

        public bool P_10Specified { get => P_10.HasValue; }
        public bool P_11Specified { get => P_11.HasValue; }
        public bool P_12Specified { get => P_12.HasValue; }
        public bool P_13Specified { get => P_13.HasValue; }
        public bool P_14Specified { get => P_14.HasValue; }
        public bool P_15Specified { get => P_15.HasValue; }
        public bool P_16Specified { get => P_16.HasValue; }
        public bool P_17Specified { get => P_17.HasValue; }
        public bool P_18Specified { get => P_18.HasValue; }
        public bool P_19Specified { get => P_19.HasValue; }
        public bool P_20Specified { get => P_20.HasValue; }
        public bool P_21Specified { get => P_21.HasValue; }
        public bool P_22Specified { get => P_22.HasValue; }
        public bool P_23Specified { get => P_23.HasValue; }
        public bool P_24Specified { get => P_24.HasValue; }
        public bool P_25Specified { get => P_25.HasValue; }
        public bool P_26Specified { get => P_26.HasValue; }
        public bool P_27Specified { get => P_27.HasValue; }
        public bool P_28Specified { get => P_28.HasValue; }
        public bool P_29Specified { get => P_29.HasValue; }
        public bool P_30Specified { get => P_30.HasValue; }
        public bool P_31Specified { get => P_31.HasValue; }
        public bool P_32Specified { get => P_32.HasValue; }
        public bool P_33Specified { get => P_33.HasValue; }
        public bool P_34Specified { get => P_34.HasValue; }
        public bool P_35Specified { get => P_35.HasValue; }
        public bool P_36Specified { get => P_36.HasValue; }
        public bool P_37Specified { get => P_37.HasValue; }
        public bool P_38Specified { get => P_38.HasValue; }
        public bool P_39Specified { get => P_39.HasValue; }
        public bool P_40Specified { get => P_40.HasValue; }
        public bool P_41Specified { get => P_41.HasValue; }
        public bool P_42Specified { get => P_42.HasValue; }
        public bool P_43Specified { get => P_43.HasValue; }
        public bool P_44Specified { get => P_44.HasValue; }
        public bool P_45Specified { get => P_45.HasValue; }
        public bool P_46Specified { get => P_46.HasValue; }
        public bool P_47Specified { get => P_47.HasValue; }
        public bool P_48Specified { get => P_48.HasValue; }
        public bool P_49Specified { get => P_49.HasValue; }
        public bool P_50Specified { get => P_50.HasValue; }
        public bool P_51Specified { get => P_51.HasValue; }
        public bool P_52Specified { get => P_52.HasValue; }
        public bool P_53Specified { get => P_53.HasValue; }
        public bool P_54Specified { get => P_54.HasValue; }
        public bool P_55Specified { get => P_55.HasValue; }
        public bool P_56Specified { get => P_56.HasValue; }
        public bool P_57Specified { get => P_57.HasValue; }
        public bool P_58Specified { get => P_58.HasValue; }
        public bool P_59Specified { get => P_59.HasValue; }
        public bool P_60Specified { get => P_60.HasValue; }
        public bool P_61Specified { get => P_61.HasValue; }
        public bool P_62Specified { get => P_62.HasValue; }
        public bool P_63Specified { get => P_63.HasValue; }
        public bool P_64Specified { get => P_64.HasValue; }
        public bool P_65Specified { get => P_65.HasValue; }
        public bool P_66Specified { get => P_66.HasValue; }
        public bool P_67Specified { get => P_67.HasValue; }
        public bool P_68Specified { get => P_68.HasValue; }
        public bool P_69Specified { get => P_69.HasValue; }


    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKEwidencja
    {

        private JPKEwidencjaSprzedazWiersz[] sprzedazWierszField;

        private JPKEwidencjaSprzedazCtrl sprzedazCtrlField;

        private JPKEwidencjaZakupWiersz[] zakupWierszField;

        private JPKEwidencjaZakupCtrl zakupCtrlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SprzedazWiersz")]
        public JPKEwidencjaSprzedazWiersz[] SprzedazWiersz
        {
            get
            {
                return this.sprzedazWierszField;
            }
            set
            {
                this.sprzedazWierszField = value;
            }
        }

        /// <remarks/>
        public JPKEwidencjaSprzedazCtrl SprzedazCtrl
        {
            get
            {
                return this.sprzedazCtrlField;
            }
            set
            {
                this.sprzedazCtrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ZakupWiersz")]
        public JPKEwidencjaZakupWiersz[] ZakupWiersz
        {
            get
            {
                return this.zakupWierszField;
            }
            set
            {
                this.zakupWierszField = value;
            }
        }

        /// <remarks/>
        public JPKEwidencjaZakupCtrl ZakupCtrl
        {
            get
            {
                return this.zakupCtrlField;
            }
            set
            {
                this.zakupCtrlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKEwidencjaSprzedazWiersz
    {
        private int lpSprzedazyField;

        private string kodKrajuNadaniaTINField;

        private string nrKontrahentaField;

        private string nazwaKontrahentaField;

        private string dowodSprzedazyField;

        private System.DateTime? dataWystawieniaField;

        private System.DateTime? dataSprzedazyField;

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

        /// <remarks/>
        public int LpSprzedazy
        {
            get
            {
                return this.lpSprzedazyField;
            }
            set
            {
                this.lpSprzedazyField = value;
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
                this.kodKrajuNadaniaTINField = value;
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
                this.nrKontrahentaField = value;
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
                this.nazwaKontrahentaField = value;
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
                this.dowodSprzedazyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime? DataWystawienia
        {
            get
            {
                return this.dataWystawieniaField;
            }
            set
            {
                this.dataWystawieniaField = value;
            }
        }

        public bool DataWystawieniaSpecified { get => DataWystawienia.HasValue; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime? DataSprzedazy
        {
            get
            {
                return this.dataSprzedazyField;
            }
            set
            {
                this.dataSprzedazyField = value;
            }
        }


        public bool DataSprzedazySpecified { get => DataSprzedazy.HasValue; }

        /// <remarks/>
        public string TypDokumentu
        {
            get
            {
                return this.typDokumentuField;
            }
            set
            {
                this.typDokumentuField = value;
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
                this.gTU_01Field = value;
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
                this.gTU_02Field = value;
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
                this.gTU_03Field = value;
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
                this.gTU_04Field = value;
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
                this.gTU_05Field = value;
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
                this.gTU_06Field = value;
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
                this.gTU_07Field = value;
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
                this.gTU_08Field = value;
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
                this.gTU_09Field = value;
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
                this.gTU_10Field = value;
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
                this.gTU_11Field = value;
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
                this.gTU_12Field = value;
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
                this.gTU_13Field = value;
            }
        }

        public bool GTU_01Specified { get => GTU_01.HasValue; }
        public bool GTU_02Specified { get => GTU_02.HasValue; }
        public bool GTU_03Specified { get => GTU_03.HasValue; }
        public bool GTU_04Specified { get => GTU_04.HasValue; }
        public bool GTU_05Specified { get => GTU_05.HasValue; }
        public bool GTU_06Specified { get => GTU_06.HasValue; }
        public bool GTU_07Specified { get => GTU_07.HasValue; }
        public bool GTU_08Specified { get => GTU_08.HasValue; }
        public bool GTU_09Specified { get => GTU_09.HasValue; }
        public bool GTU_10Specified { get => GTU_10.HasValue; }
        public bool GTU_11Specified { get => GTU_11.HasValue; }
        public bool GTU_12Specified { get => GTU_12.HasValue; }
        public bool GTU_13Specified { get => GTU_13.HasValue; }



        /// <remarks/>
        public int? SW
        {
            get
            {
                return this.swField;
            }
            set
            {
                this.swField = value;
            }
        }
        public bool SWSpecified { get => SW.HasValue; }

        /// <remarks/>
        public int? EE
        {
            get
            {
                return this.eeField;
            }
            set
            {
                this.eeField = value;
            }
        }
        public bool EESpecified { get => EE.HasValue; }

        /// <remarks/>
        public int? TP
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        public bool TPSpecified { get => TP.HasValue; }

        /// <remarks/>
        public int? TT_WNT
        {
            get
            {
                return this.tT_WNTField;
            }
            set
            {
                this.tT_WNTField = value;
            }
        }

        public bool TT_WNTSpecified { get => TT_WNT.HasValue; }

        /// <remarks/>
        public int? TT_D
        {
            get
            {
                return this.tT_DField;
            }
            set
            {
                this.tT_DField = value;
            }
        }

        public bool TT_DSpecified { get => TT_D.HasValue; }

        /// <remarks/>
        public int? MR_T
        {
            get
            {
                return this.mR_TField;
            }
            set
            {
                this.mR_TField = value;
            }
        }

        public bool MR_TSpecified { get => MR_T.HasValue; }

        /// <remarks/>
        public int? MR_UZ
        {
            get
            {
                return this.mR_UZField;
            }
            set
            {
                this.mR_UZField = value;
            }
        }
        public bool MR_UZSpecified { get => MR_UZ.HasValue; }


        /// <remarks/>
        public int? I_42
        {
            get
            {
                return this.i_42Field;
            }
            set
            {
                this.i_42Field = value;
            }
        }

        public bool I_42Specified { get => I_42.HasValue; }

        /// <remarks/>
        public int? I_63
        {
            get
            {
                return this.i_63Field;
            }
            set
            {
                this.i_63Field = value;
            }
        }
        public bool I_63Specified { get => I_63.HasValue; }

        /// <remarks/>
        public int? B_SPV
        {
            get
            {
                return this.b_SPVField;
            }
            set
            {
                this.b_SPVField = value;
            }
        }
        public bool B_SPVSpecified { get => B_SPV.HasValue; }
        /// <remarks/>
        public int? B_SPV_DOSTAWA
        {
            get
            {
                return this.b_SPV_DOSTAWAField;
            }
            set
            {
                this.b_SPV_DOSTAWAField = value;
            }
        }

        public bool B_SPV_DOSTAWASpecified { get => B_SPV_DOSTAWA.HasValue; }

        /// <remarks/>
        public int? B_MPV_PROWIZJA
        {
            get
            {
                return this.b_MPV_PROWIZJAField;
            }
            set
            {
                this.b_MPV_PROWIZJAField = value;
            }
        }
        public bool B_MPV_PROWIZJASpecified { get => B_MPV_PROWIZJA.HasValue; }

        /// <remarks/>
        public int? MPP
        {
            get
            {
                return this.mPPField;
            }
            set
            {
                this.mPPField = value;
            }
        }
        public bool MPPSpecified { get => MPP.HasValue; }

        /// <remarks/>
        public int? KorektaPodstawyOpodt
        {
            get
            {
                return this.korektaPodstawyOpodtField;
            }
            set
            {
                this.korektaPodstawyOpodtField = value;
            }
        }
        public bool KorektaPodstawyOpodtSpecified { get => KorektaPodstawyOpodt.HasValue; }
        /// <remarks/>
        public decimal? K_10
        {
            get
            {
                return this.k_10Field;
            }
            set
            {
                this.k_10Field = value;
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
                this.k_11Field = value;
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
                this.k_12Field = value;
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
                this.k_13Field = value;
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
                this.k_14Field = value;
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
                this.k_15Field = value;
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
                this.k_16Field = value;
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
                this.k_17Field = value;
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
                this.k_18Field = value;
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
                this.k_19Field = value;
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
                this.k_20Field = value;
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
                this.k_21Field = value;
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
                this.k_22Field = value;
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
                this.k_23Field = value;
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
                this.k_24Field = value;
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
                this.k_25Field = value;
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
                this.k_26Field = value;
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
                this.k_27Field = value;
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
                this.k_28Field = value;
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
                this.k_29Field = value;
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
                this.k_30Field = value;
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
                this.k_31Field = value;
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
                this.k_32Field = value;
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
                this.k_33Field = value;
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
                this.k_34Field = value;
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
                this.k_35Field = value;
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
                this.k_36Field = value;
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
                this.sprzedazVAT_MarzaField = value;
            }
        }

        public bool SprzedazVAT_MarzaSpecified { get => SprzedazVAT_Marza.HasValue; }

        public bool K_10Specified { get => K_10.HasValue; }
        public bool K_11Specified { get => K_11.HasValue; }
        public bool K_12Specified { get => K_12.HasValue; }
        public bool K_13Specified { get => K_13.HasValue; }
        public bool K_14Specified { get => K_14.HasValue; }
        public bool K_15Specified { get => K_15.HasValue; }
        public bool K_16Specified { get => K_16.HasValue; }
        public bool K_17Specified { get => K_17.HasValue; }
        public bool K_18Specified { get => K_18.HasValue; }
        public bool K_19Specified { get => K_19.HasValue; }
        public bool K_20Specified { get => K_20.HasValue; }
        public bool K_21Specified { get => K_21.HasValue; }
        public bool K_22Specified { get => K_22.HasValue; }
        public bool K_23Specified { get => K_23.HasValue; }
        public bool K_24Specified { get => K_24.HasValue; }
        public bool K_25Specified { get => K_25.HasValue; }
        public bool K_26Specified { get => K_26.HasValue; }
        public bool K_27Specified { get => K_27.HasValue; }
        public bool K_28Specified { get => K_28.HasValue; }
        public bool K_29Specified { get => K_29.HasValue; }
        public bool K_30Specified { get => K_30.HasValue; }
        public bool K_31Specified { get => K_31.HasValue; }
        public bool K_32Specified { get => K_32.HasValue; }
        public bool K_33Specified { get => K_33.HasValue; }
        public bool K_34Specified { get => K_34.HasValue; }
        public bool K_35Specified { get => K_35.HasValue; }
        public bool K_36Specified { get => K_36.HasValue; }

        

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKEwidencjaSprzedazCtrl
    {

        private int liczbaWierszySprzedazyField;

        private decimal podatekNaleznyField;

        /// <remarks/>
        public int LiczbaWierszySprzedazy
        {
            get
            {
                return this.liczbaWierszySprzedazyField;
            }
            set
            {
                this.liczbaWierszySprzedazyField = value;
            }
        }

        /// <remarks/>
        public decimal PodatekNalezny
        {
            get
            {
                return this.podatekNaleznyField;
            }
            set
            {
                this.podatekNaleznyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKEwidencjaZakupWiersz
    {

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
                this.lpZakupuField = value;
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
                this.kodKrajuNadaniaTINField = value;
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
                this.nrDostawcyField = value;
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
                this.nazwaDostawcyField = value;
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
                this.dowodZakupuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DataZakupu
        {

            get
            {
                return this.dataZakupuField;
            }
            set
            {
                this.dataZakupuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime? DataWplywu
        {
            get
            {
                return this.dataWplywuField;
            }
            set
            {
                this.dataWplywuField = value;
            }
        }

        public bool DataWplywuSpecified { get => DataWplywu.HasValue; }

        /// <remarks/>
        public string DokumentZakupu
        {
            get
            {
                return this.dokumentZakupuField;
            }
            set
            {
                this.dokumentZakupuField = value;
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
                this.mPPField = value;
            }
        }

        public bool MPPSpecified { get => MPP.HasValue; }

        /// <remarks/>
        public int? IMP
        {
            get
            {
                return this.iMPField;
            }
            set
            {
                this.iMPField = value;
            }
        }

        public bool IMPSpecified { get => IMP.HasValue; }

        /// <remarks/>
        public decimal? K_40
        {
            get
            {
                return this.k_40Field;
            }
            set
            {
                this.k_40Field = value;
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
                this.k_41Field = value;
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
                this.k_42Field = value;
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
                this.k_43Field = value;
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
                this.k_44Field = value;
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
                this.k_45Field = value;
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
                this.k_46Field = value;
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
                this.k_47Field = value;
            }
        }

        public bool K_40Specified { get => K_40.HasValue; }
        public bool K_41Specified { get => K_41.HasValue; }
        public bool K_42Specified { get => K_42.HasValue; }
        public bool K_43Specified { get => K_43.HasValue; }
        public bool K_44Specified { get => K_44.HasValue; }
        public bool K_45Specified { get => K_45.HasValue; }
        public bool K_46Specified { get => K_46.HasValue; }
        public bool K_47Specified { get => K_47.HasValue; }


        /// <remarks/>
        public decimal? ZakupVAT_Marza
        {
            get
            {
                return this.zakupVAT_MarzaField;
            }
            set
            {
                this.zakupVAT_MarzaField = value;
            }
        }

        public bool ZakupVAT_MarzaSpecified { get => ZakupVAT_Marza.HasValue; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public partial class JPKEwidencjaZakupCtrl
    {

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
                this.liczbaWierszyZakupowField = value;
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
                this.podatekNaliczonyField = value;
            }
        }
    }


}