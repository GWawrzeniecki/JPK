using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Business.JPKTest
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

    private byte kodUrzeduField;

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
    public byte KodUrzedu
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

    private string kodSystemowyField;

    private string wersjaSchemyField;

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

    private uint telefonField;

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
    public uint Telefon
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

    private string kodPodatkuField;

    private string rodzajZobowiazaniaField;

    private string wersjaSchemyField;

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

    private byte p_10Field;

    private byte p_11Field;

    private byte p_12Field;

    private byte p_13Field;

    private byte p_14Field;

    private byte p_15Field;

    private byte p_16Field;

    private byte p_17Field;

    private byte p_18Field;

    private byte p_19Field;

    private byte p_20Field;

    private byte p_21Field;

    private byte p_22Field;

    private byte p_23Field;

    private byte p_24Field;

    private byte p_25Field;

    private byte p_26Field;

    private byte p_27Field;

    private byte p_28Field;

    private byte p_29Field;

    private byte p_30Field;

    private byte p_31Field;

    private byte p_32Field;

    private byte p_33Field;

    private byte p_34Field;

    private byte p_35Field;

    private byte p_36Field;

    private byte p_37Field;

    private byte p_38Field;

    private byte p_39Field;

    private byte p_40Field;

    private byte p_41Field;

    private byte p_42Field;

    private byte p_43Field;

    private byte p_44Field;

    private byte p_45Field;

    private byte p_46Field;

    private byte p_47Field;

    private byte p_48Field;

    private byte p_49Field;

    private byte p_50Field;

    private byte p_51Field;

    private byte p_52Field;

    private byte p_53Field;

    private byte p_54Field;

    private byte p_55Field;

    private byte p_59Field;

    private byte p_60Field;

    private string p_61Field;

    private byte p_62Field;

    private byte p_63Field;

    private byte p_64Field;

    private byte p_65Field;

    private byte p_66Field;

    private byte p_67Field;

    private byte p_68Field;

    private byte p_69Field;

    private string p_ORDZUField;

    /// <remarks/>
    public byte P_10
    {
        get
        {
            return this.p_10Field;
        }
        set
        {
            this.p_10Field = value;
        }
    }

    /// <remarks/>
    public byte P_11
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

    /// <remarks/>
    public byte P_12
    {
        get
        {
            return this.p_12Field;
        }
        set
        {
            this.p_12Field = value;
        }
    }

    /// <remarks/>
    public byte P_13
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

    /// <remarks/>
    public byte P_14
    {
        get
        {
            return this.p_14Field;
        }
        set
        {
            this.p_14Field = value;
        }
    }

    /// <remarks/>
    public byte P_15
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
    public byte P_16
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
    public byte P_17
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
    public byte P_18
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
    public byte P_19
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
    public byte P_20
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
    public byte P_21
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
    public byte P_22
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
    public byte P_23
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
    public byte P_24
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
    public byte P_25
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
    public byte P_26
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
    public byte P_27
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
    public byte P_28
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
    public byte P_29
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
    public byte P_30
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
    public byte P_31
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
    public byte P_32
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

    /// <remarks/>
    public byte P_33
    {
        get
        {
            return this.p_33Field;
        }
        set
        {
            this.p_33Field = value;
        }
    }

    /// <remarks/>
    public byte P_34
    {
        get
        {
            return this.p_34Field;
        }
        set
        {
            this.p_34Field = value;
        }
    }

    /// <remarks/>
    public byte P_35
    {
        get
        {
            return this.p_35Field;
        }
        set
        {
            this.p_35Field = value;
        }
    }

    /// <remarks/>
    public byte P_36
    {
        get
        {
            return this.p_36Field;
        }
        set
        {
            this.p_36Field = value;
        }
    }

    /// <remarks/>
    public byte P_37
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
    public byte P_38
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

    /// <remarks/>
    public byte P_39
    {
        get
        {
            return this.p_39Field;
        }
        set
        {
            this.p_39Field = value;
        }
    }

    /// <remarks/>
    public byte P_40
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
    public byte P_41
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
    public byte P_42
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
    public byte P_43
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

    /// <remarks/>
    public byte P_44
    {
        get
        {
            return this.p_44Field;
        }
        set
        {
            this.p_44Field = value;
        }
    }

    /// <remarks/>
    public byte P_45
    {
        get
        {
            return this.p_45Field;
        }
        set
        {
            this.p_45Field = value;
        }
    }

    /// <remarks/>
    public byte P_46
    {
        get
        {
            return this.p_46Field;
        }
        set
        {
            this.p_46Field = value;
        }
    }

    /// <remarks/>
    public byte P_47
    {
        get
        {
            return this.p_47Field;
        }
        set
        {
            this.p_47Field = value;
        }
    }

    /// <remarks/>
    public byte P_48
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

    /// <remarks/>
    public byte P_49
    {
        get
        {
            return this.p_49Field;
        }
        set
        {
            this.p_49Field = value;
        }
    }

    /// <remarks/>
    public byte P_50
    {
        get
        {
            return this.p_50Field;
        }
        set
        {
            this.p_50Field = value;
        }
    }

    /// <remarks/>
    public byte P_51
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

    /// <remarks/>
    public byte P_52
    {
        get
        {
            return this.p_52Field;
        }
        set
        {
            this.p_52Field = value;
        }
    }

    /// <remarks/>
    public byte P_53
    {
        get
        {
            return this.p_53Field;
        }
        set
        {
            this.p_53Field = value;
        }
    }

    /// <remarks/>
    public byte P_54
    {
        get
        {
            return this.p_54Field;
        }
        set
        {
            this.p_54Field = value;
        }
    }

    /// <remarks/>
    public byte P_55
    {
        get
        {
            return this.p_55Field;
        }
        set
        {
            this.p_55Field = value;
        }
    }

    /// <remarks/>
    public byte P_59
    {
        get
        {
            return this.p_59Field;
        }
        set
        {
            this.p_59Field = value;
        }
    }

    /// <remarks/>
    public byte P_60
    {
        get
        {
            return this.p_60Field;
        }
        set
        {
            this.p_60Field = value;
        }
    }

    /// <remarks/>
    public string P_61
    {
        get
        {
            return this.p_61Field;
        }
        set
        {
            this.p_61Field = value;
        }
    }

    /// <remarks/>
    public byte P_62
    {
        get
        {
            return this.p_62Field;
        }
        set
        {
            this.p_62Field = value;
        }
    }

    /// <remarks/>
    public byte P_63
    {
        get
        {
            return this.p_63Field;
        }
        set
        {
            this.p_63Field = value;
        }
    }

    /// <remarks/>
    public byte P_64
    {
        get
        {
            return this.p_64Field;
        }
        set
        {
            this.p_64Field = value;
        }
    }

    /// <remarks/>
    public byte P_65
    {
        get
        {
            return this.p_65Field;
        }
        set
        {
            this.p_65Field = value;
        }
    }

    /// <remarks/>
    public byte P_66
    {
        get
        {
            return this.p_66Field;
        }
        set
        {
            this.p_66Field = value;
        }
    }

    /// <remarks/>
    public byte P_67
    {
        get
        {
            return this.p_67Field;
        }
        set
        {
            this.p_67Field = value;
        }
    }

    /// <remarks/>
    public byte P_68
    {
        get
        {
            return this.p_68Field;
        }
        set
        {
            this.p_68Field = value;
        }
    }

    /// <remarks/>
    public byte P_69
    {
        get
        {
            return this.p_69Field;
        }
        set
        {
            this.p_69Field = value;
        }
    }

    /// <remarks/>
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
public partial class JPKEwidencja
{

    private JPKEwidencjaSprzedazWiersz sprzedazWierszField;

    private JPKEwidencjaSprzedazCtrl sprzedazCtrlField;

    private JPKEwidencjaZakupWiersz zakupWierszField;

    private JPKEwidencjaZakupCtrl zakupCtrlField;

    /// <remarks/>
    public JPKEwidencjaSprzedazWiersz SprzedazWiersz
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
    public JPKEwidencjaZakupWiersz ZakupWiersz
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

    private byte lpSprzedazyField;

    private string kodKrajuNadaniaTINField;

    private uint nrKontrahentaField;

    private string nazwaKontrahentaField;

    private ushort dowodSprzedazyField;

    private System.DateTime dataWystawieniaField;

    private System.DateTime dataSprzedazyField;

    private string typDokumentuField;

    private byte gTU_01Field;

    private byte gTU_02Field;

    private byte gTU_03Field;

    private byte gTU_04Field;

    private byte gTU_05Field;

    private byte gTU_06Field;

    private byte gTU_07Field;

    private byte gTU_08Field;

    private byte gTU_09Field;

    private byte gTU_10Field;

    private byte gTU_11Field;

    private byte gTU_12Field;

    private byte gTU_13Field;

    private byte swField;

    private byte eeField;

    private byte tpField;

    private byte tT_WNTField;

    private byte tT_DField;

    private byte mR_TField;

    private byte mR_UZField;

    private byte i_42Field;

    private byte i_63Field;

    private byte b_SPVField;

    private byte b_SPV_DOSTAWAField;

    private byte b_MPV_PROWIZJAField;

    private byte mPPField;

    private byte korektaPodstawyOpodtField;

    private byte k_10Field;

    private byte k_11Field;

    private byte k_12Field;

    private byte k_13Field;

    private byte k_14Field;

    private byte k_15Field;

    private byte k_16Field;

    private byte k_17Field;

    private byte k_18Field;

    private byte k_19Field;

    private byte k_20Field;

    private byte k_21Field;

    private byte k_22Field;

    private byte k_23Field;

    private byte k_24Field;

    private byte k_25Field;

    private byte k_26Field;

    private byte k_27Field;

    private byte k_28Field;

    private byte k_29Field;

    private byte k_30Field;

    private byte k_31Field;

    private byte k_32Field;

    private byte k_33Field;

    private byte k_34Field;

    private byte k_35Field;

    private byte k_36Field;

    private byte sprzedazVAT_MarzaField;

    /// <remarks/>
    public byte LpSprzedazy
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
    public uint NrKontrahenta
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
    public ushort DowodSprzedazy
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
    public System.DateTime DataWystawienia
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DataSprzedazy
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
    public byte GTU_01
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
    public byte GTU_02
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
    public byte GTU_03
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
    public byte GTU_04
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
    public byte GTU_05
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
    public byte GTU_06
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
    public byte GTU_07
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
    public byte GTU_08
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
    public byte GTU_09
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
    public byte GTU_10
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
    public byte GTU_11
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
    public byte GTU_12
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
    public byte GTU_13
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

    /// <remarks/>
    public byte SW
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

    /// <remarks/>
    public byte EE
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

    /// <remarks/>
    public byte TP
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

    /// <remarks/>
    public byte TT_WNT
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

    /// <remarks/>
    public byte TT_D
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

    /// <remarks/>
    public byte MR_T
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

    /// <remarks/>
    public byte MR_UZ
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

    /// <remarks/>
    public byte I_42
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

    /// <remarks/>
    public byte I_63
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

    /// <remarks/>
    public byte B_SPV
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

    /// <remarks/>
    public byte B_SPV_DOSTAWA
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

    /// <remarks/>
    public byte B_MPV_PROWIZJA
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

    /// <remarks/>
    public byte MPP
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

    /// <remarks/>
    public byte KorektaPodstawyOpodt
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

    /// <remarks/>
    public byte K_10
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
    public byte K_11
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
    public byte K_12
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
    public byte K_13
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
    public byte K_14
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
    public byte K_15
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
    public byte K_16
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
    public byte K_17
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
    public byte K_18
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
    public byte K_19
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
    public byte K_20
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
    public byte K_21
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
    public byte K_22
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
    public byte K_23
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
    public byte K_24
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
    public byte K_25
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
    public byte K_26
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
    public byte K_27
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
    public byte K_28
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
    public byte K_29
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
    public byte K_30
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
    public byte K_31
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
    public byte K_32
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
    public byte K_33
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
    public byte K_34
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
    public byte K_35
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
    public byte K_36
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
    public byte SprzedazVAT_Marza
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
public partial class JPKEwidencjaSprzedazCtrl
{

    private byte liczbaWierszySprzedazyField;

    private byte podatekNaleznyField;

    /// <remarks/>
    public byte LiczbaWierszySprzedazy
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
    public byte PodatekNalezny
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

    private byte lpZakupuField;

    private string kodKrajuNadaniaTINField;

    private uint nrDostawcyField;

    private string nazwaDostawcyField;

    private byte dowodZakupuField;

    private System.DateTime dataZakupuField;

    private System.DateTime dataWplywuField;

    private string dokumentZakupuField;

    private byte mPPField;

    private byte iMPField;

    private byte k_40Field;

    private byte k_41Field;

    private byte k_42Field;

    private byte k_43Field;

    private byte k_44Field;

    private byte k_45Field;

    private byte k_46Field;

    private byte k_47Field;

    private byte zakupVAT_MarzaField;

    /// <remarks/>
    public byte LpZakupu
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
    public uint NrDostawcy
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
    public byte DowodZakupu
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
    public System.DateTime DataWplywu
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
    public byte MPP
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

    /// <remarks/>
    public byte IMP
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

    /// <remarks/>
    public byte K_40
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
    public byte K_41
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
    public byte K_42
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
    public byte K_43
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
    public byte K_44
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
    public byte K_45
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
    public byte K_46
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
    public byte K_47
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

    /// <remarks/>
    public byte ZakupVAT_Marza
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
public partial class JPKEwidencjaZakupCtrl
{

    private byte liczbaWierszyZakupowField;

    private byte podatekNaliczonyField;

    /// <remarks/>
    public byte LiczbaWierszyZakupow
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
    public byte PodatekNaliczony
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