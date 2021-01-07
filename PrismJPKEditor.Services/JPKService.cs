using PrismJPKEditor.Business.Models;
using PrismJPKEditor.Core.SharedVariables;
using PrismJPKEditor.Services.Interfaces;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Linq;
using System;
using PrismJPKEditor.Business;
using System.Collections.Generic;

namespace PrismJPKEditor.Services
{
    public class JPKService : IJPKService
    {
        private readonly ISessionContext _sessionContext;
        private Business.JPKXMLModels.JPK _jpkXML;

        #region constructor

        public JPKService(ISessionContext sessionContext)
        {

            this._sessionContext = sessionContext;
        }

        #endregion

        #region public methods

        public async Task LoadDBAsync(string path)
        {
            _jpkXML = await TryToDeserializeObjectAsync<Business.JPKXMLModels.JPK>(path);
            var jpk = new JPK();
            LoadDeclarationFields(jpk.Declaration);
            CopyDeclarationFields(_jpkXML.Deklaracja.PozycjeSzczegolowe, jpk.Declaration, GenerateP_XPropertiesName());
            CopySellRows(_jpkXML.Ewidencja.SprzedazWiersz, jpk,jpk.Sell);
            CoppySellRowsCtrl(_jpkXML.Ewidencja.SprzedazCtrl, jpk, jpk.Sell);
            CopyBuyRows(_jpkXML.Ewidencja.ZakupWiersz, jpk);
            CoppyBuyRowsCtrl(_jpkXML.Ewidencja.ZakupCtrl, jpk);
            _sessionContext.JPKDataSource = jpk;
        }



        public async Task SaveAsync(string path)
        {
            if (_jpkXML == null)
                return;

            var jpk = _sessionContext.JPKDataSource;
            CopyDeclarationFields(jpk.Declaration, _jpkXML.Deklaracja.PozycjeSzczegolowe, GenerateP_XPropertiesName());
            CopySellRows(jpk, _jpkXML);
            CoppySellRowsCtrl(jpk, _jpkXML);
            CopyBuyRows(jpk, _jpkXML);
            CopyBuyRowsCtrl(jpk, _jpkXML);
            await TryToSerializeObjectAsync(path, _jpkXML);
        }



        public async Task SaveAsAsync(string path)
        {
            await SaveAsync(path);
        }

        #endregion

        #region db helpers

        private void CopyDeclarationFields<T>(T source, Declaration declaration, string[] propertiesNames)
        {
            var dic = declaration.Declarations.ToDictionary(i => i.FieldName, i => i);
            foreach (var propertyName in propertiesNames)
            {
                var prop = source.GetType().GetProperty(propertyName);
                if (prop != null)
                {
                    dic[propertyName].GridValue = prop.GetValue(source);
                }
            }

        }

        private void CopyDeclarationFields<T>(Declaration source, T destination, string[] propertiesNames)
        {
            var dic = source.Declarations.ToDictionary(i => i.FieldName, i => i);
            foreach (var propertyName in propertiesNames)
            {

                var value = dic[propertyName].XMLValue;
                var prop = destination.GetType().GetProperty(propertyName);

                if (prop != null)
                {
                    prop.SetValue(destination, value);
                }
            }

        }

        private void CopyProperties<T, K>(T source, K destination, string[] propertiesNames)
        {
            foreach (var propertyName in propertiesNames)
            {
                var prop = source.GetType().GetProperty(propertyName);
                if (prop != null)
                {
                    var value = prop.GetValue(source);

                    destination.GetType().GetProperty(propertyName).SetValue(destination, value);
                }
            }
        }


        private string[] GenerateP_XPropertiesName()
        {
            var propertiesName = new string[61];
            var propName = "P_";
            for (int i = 10; i < propertiesName.Length + 10; i++)
            {
                propertiesName[i - 10] = $"{propName}{i}";
            }
            propertiesName[60] = "P_ORDZU";
            return propertiesName;
        }

        private void CopySellRows(Business.JPKXMLModels.JPKEwidencjaSprzedazWiersz[] sprzedazWiersz, JPK jpk, Sell sell)
        {
            var sellRows = MapperHelper.Map<List<SellRow>>(cfg => cfg.CreateMap<Business.JPKXMLModels.JPKEwidencjaSprzedazWiersz, SellRow>(), sprzedazWiersz);
            foreach (var sellRow in sellRows) //TO Do change IT!!!!
                sellRow.Sell = sell;
            jpk.Sell.SellRows = sellRows;

        }

        private void CoppySellRowsCtrl(Business.JPKXMLModels.JPKEwidencjaSprzedazCtrl sprzedazCtrl, JPK jpk, Sell sell)
        {
            var sellCtrl = MapperHelper.Map<SellCtrl>(cfg => cfg.CreateMap<Business.JPKXMLModels.JPKEwidencjaSprzedazCtrl, SellCtrl>(), sprzedazCtrl);
            sellCtrl.Sell = sell; //TO DO change it
            sellCtrl.ValidatePodatekNalezny(); // TO Do change it
            jpk.Sell.SellCtrl.Add(sellCtrl);
        }

        private void CoppySellRowsCtrl(JPK jpk, Business.JPKXMLModels.JPK jpkXML)
        {
            if (jpk.Sell.SellCtrl.Count > 0)
            {
                var ctrl = MapperHelper.Map<Business.JPKXMLModels.JPKEwidencjaSprzedazCtrl>(cfg => cfg.CreateMap<SellCtrl, Business.JPKXMLModels.JPKEwidencjaSprzedazCtrl>(), jpk.Sell.SellCtrl[0]);
                jpkXML.Ewidencja.SprzedazCtrl = ctrl;
            }
        }

        private void CopySellRows(JPK jpk, Business.JPKXMLModels.JPK jpkXML)
        {
            var sellRows = MapperHelper.Map<Business.JPKXMLModels.JPKEwidencjaSprzedazWiersz[]>(cfg => cfg.CreateMap<SellRow, Business.JPKXMLModels.JPKEwidencjaSprzedazWiersz>(), jpk.Sell.SellRows);
            jpkXML.Ewidencja.SprzedazWiersz = sellRows;
        }

        private void CopyBuyRows(JPK jpk, Business.JPKXMLModels.JPK jpkXML)
        {
            var buyRows = MapperHelper.Map<Business.JPKXMLModels.JPKEwidencjaZakupWiersz[]>(cfg => cfg.CreateMap<BuyRow, Business.JPKXMLModels.JPKEwidencjaZakupWiersz>(), jpk.Buy.BuyRows);
            jpkXML.Ewidencja.ZakupWiersz = buyRows;
        }

        private void CopyBuyRowsCtrl(JPK jpk, Business.JPKXMLModels.JPK jpkXML)
        {
            if (jpk.Buy.BuyCtrl.Count > 0)
            {
                var ctrl = MapperHelper.Map<Business.JPKXMLModels.JPKEwidencjaZakupCtrl>(cfg => cfg.CreateMap<BuyCtrl, Business.JPKXMLModels.JPKEwidencjaZakupCtrl>(), jpk.Buy.BuyCtrl[0]);
                jpkXML.Ewidencja.ZakupCtrl = ctrl;
            }
        }

        private void CopyBuyRows(Business.JPKXMLModels.JPKEwidencjaZakupWiersz[] zakupWiersz, JPK jpk)
        {
            var buyRows = MapperHelper.Map<List<BuyRow>>(cfg => cfg.CreateMap<Business.JPKXMLModels.JPKEwidencjaZakupWiersz, BuyRow>(), zakupWiersz);
            jpk.Buy.BuyRows = buyRows;
        }

        private void CoppyBuyRowsCtrl(Business.JPKXMLModels.JPKEwidencjaZakupCtrl zakupCtrl, JPK jpk)
        {
            var buyCtrl = MapperHelper.Map<BuyCtrl>(cfg => cfg.CreateMap<Business.JPKXMLModels.JPKEwidencjaZakupCtrl, BuyCtrl>(), zakupCtrl);
            jpk.Buy.BuyCtrl.Add(buyCtrl);
        }



        #endregion

        #region loading declarations
        private void LoadDeclarationFields(Declaration declaration)
        {

            //To DO add pair information
            declaration.Declarations.Add(new DeclarationField("P_10", "Dostawa towarów oraz świadczenie usług, na terytorium kraju, zwolnione od podatku - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration));

            declaration.Declarations.Add(new DeclarationField("P_11", "Dostawa towarów oraz świadczenie usług poza terytorium kraju - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_12"));
            declaration.Declarations.Add(new DeclarationField("P_12", "Świadczenie usług, o których mowa w art.100 ust.1 pkt 4 ustawy - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, false, "P_11"));

            declaration.Declarations.Add(new DeclarationField("P_13", "Dostawa towarów oraz świadczenie usług, na terytorium kraju, opodatkowane stawką 0% - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_14"));
            declaration.Declarations.Add(new DeclarationField("P_14", "Dostawa towarów, na terytorium kraju, opodatkowana stawką 0%, o której mowa w art.129 ustawy - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, false, "P_13"));
            declaration.Declarations.Add(new DeclarationField("P_15", "Dostawa towarów oraz świadczenie usług, na terytorium kraju, opodatkowane stawką 5% - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_16"));
            declaration.Declarations.Add(new DeclarationField("P_16", "Dostawa towarów oraz świadczenie usług, na terytorium kraju, opodatkowane stawką 5% - podatek należny", DeclarationFieldType.NullableInt, declaration, true, true, "P_15"));
            declaration.Declarations.Add(new DeclarationField("P_17", "Dostawa towarów oraz świadczenie usług, na terytorium kraju, opodatkowane stawką odpowiednio 7% albo 8% - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_18"));
            declaration.Declarations.Add(new DeclarationField("P_18", "Dostawa towarów oraz świadczenie usług, na terytorium kraju, opodatkowane stawką odpowiednio 7% albo 8% - podatek należny", DeclarationFieldType.NullableInt, declaration, true, true, "P_17"));
            declaration.Declarations.Add(new DeclarationField("P_19", "Dostawa towarów oraz świadczenie usług, na terytorium kraju, opodatkowane stawką odpowiednio 22% albo 23% - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_20"));
            declaration.Declarations.Add(new DeclarationField("P_20", "Dostawa towarów oraz świadczenie usług, na terytorium kraju, opodatkowane stawką odpowiednio 22% albo 23% - podatek należny", DeclarationFieldType.NullableInt, declaration, true, true, "P_19"));

            declaration.Declarations.Add(new DeclarationField("P_21", "Wewnątrzwspólnotowa dostawa towarów - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_22", "Eksport towarów - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration));

            declaration.Declarations.Add(new DeclarationField("P_23", "Wewnątrzwspólnotowe nabycie towarów - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_24"));
            declaration.Declarations.Add(new DeclarationField("P_24", "Wewnątrzwspólnotowe nabycie towarów - podatek należny", DeclarationFieldType.NullableInt, declaration, true, true, "P_23"));
            declaration.Declarations.Add(new DeclarationField("P_25", "Import towarów - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_26"));
            declaration.Declarations.Add(new DeclarationField("P_26", "Import towarów - podatek należny", DeclarationFieldType.NullableInt, declaration, true, true, "P_25"));
            declaration.Declarations.Add(new DeclarationField("P_27", "Import usług, z wyłączeniem usług, do których stosuje się art.28b ustawy - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_28"));
            declaration.Declarations.Add(new DeclarationField("P_28", "Import usług, z wyłączeniem usług, do których stosuje się art.28b ustawy - podatek należny", DeclarationFieldType.NullableInt, declaration, true, true, "P_27"));
            declaration.Declarations.Add(new DeclarationField("P_29", "Import usług, do których stosuje się art.28b ustawy  - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_30"));
            declaration.Declarations.Add(new DeclarationField("P_30", "Import usług, do których stosuje się art.28b ustawy - podatek należny", DeclarationFieldType.NullableInt, declaration, true, true, "P_29"));
            declaration.Declarations.Add(new DeclarationField("P_31", "Dostawa towarów, dla której podatnikiem jest nabywca (art.17 ust.1 pkt 5 ustawy (wypełnia nabywca)) - podstawa opodatkowania", DeclarationFieldType.NullableInt, declaration, true, true, "P_32"));
            declaration.Declarations.Add(new DeclarationField("P_32", "Dostawa towarów, dla której podatnikiem jest nabywca (art.17 ust.1 pkt 5 ustawy (wypełnia nabywca)) - podatek należny", DeclarationFieldType.NullableInt, declaration, true, true, "P_31"));

            declaration.Declarations.Add(new DeclarationField("P_33", "Kwota podatku należnego od towarów i usług objętych spisem z natury", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_34", "Zwrot odliczonej lub zwróconej kwoty wydatkowanej na zakup kas rejestrujących", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_35", "Kwota podatku należnego od wewnątrzwspólnotowego nabycia środków transportu", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_36", "Kwota podatku od wewnątrzwspólnotowego nabycia towarów, o których mowa w art. 103 ust. 5aa ustawy, podlegająca wpłacie w terminach, o których mowa w art. 103 ust. 5a i 5b ustawy", DeclarationFieldType.NullableInt, declaration));

            declaration.Declarations.Add(new DeclarationField("P_37", "Razem podstawa opodatkowania", DeclarationFieldType.Calculable, declaration, true, false, "P_38", true));
            declaration.Declarations.Add(new DeclarationField("P_38", "Razem podatek należny", DeclarationFieldType.Calculable, declaration, true, true, "P_37", true));

            declaration.Declarations.Add(new DeclarationField("P_39", "Kwota nadwyżki z poprzedniej deklaracji", DeclarationFieldType.NullableInt, declaration));

            declaration.Declarations.Add(new DeclarationField("P_40", "Nabycie towarów i usług zaliczanych u podatnika do środków trwałych - wartość netto", DeclarationFieldType.NullableInt, declaration, true, true, "P_41"));
            declaration.Declarations.Add(new DeclarationField("P_41", "Nabycie towarów i usług zaliczanych u podatnika do środków trwałych - podatek naliczony", DeclarationFieldType.NullableInt, declaration, true, true, "P_40"));
            declaration.Declarations.Add(new DeclarationField("P_42", "Nabycie towarów i usług pozostałych - wartość netto", DeclarationFieldType.NullableInt, declaration, true, true, "P_43"));
            declaration.Declarations.Add(new DeclarationField("P_43", "Nabycie towarów i usług pozostałych - podatek naliczony", DeclarationFieldType.NullableInt, declaration, true, true, "P_42"));

            declaration.Declarations.Add(new DeclarationField("P_44", "Korekta podatku naliczonego od nabycia środków trwałych", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_45", "Korekta podatku naliczonego od pozostałych nabyć", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_46", "Korekta podatku naliczonego, o której mowa w art. 89b ust. 1 ustawy", DeclarationFieldType.NegativeOrZeroOrNull, declaration));
            declaration.Declarations.Add(new DeclarationField("P_47", "Korekta podatku naliczonego, o której mowa w art. 89b ust. 4 ustawy", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_48", "Razem kwota podatku naliczonego do odliczenia", DeclarationFieldType.Calculable, declaration));

            declaration.Declarations.Add(new DeclarationField("P_49", "Kwota wydatkowana na zakup kas rejestrujących - do odliczenia", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_50", "Kwota podatku objęta zaniechaniem poboru", DeclarationFieldType.NullableInt, declaration));

            declaration.Declarations.Add(new DeclarationField("P_51", "Kwota podatku podlegającego wpłacie do urzędu skarbowego", DeclarationFieldType.IntOrZero, declaration));

            declaration.Declarations.Add(new DeclarationField("P_52", "Kwota wydatkowana na zakup kas rejestrujących - do zwrotu", DeclarationFieldType.NullableInt, declaration));
            declaration.Declarations.Add(new DeclarationField("P_53", "Nadwyżka podatku naliczonego nad należnym", DeclarationFieldType.NullableInt, declaration));



            var P_54 = new DeclarationField("P_54", "Kwota do zwrotu na rachunek bankowy", DeclarationFieldType.NullableInt, declaration)
            {
                IsInNestedPair = true,
                IsRequiredInNestedPair = true,
                IsChoicePair = true


            };
            (P_54 as IFieldMultiplePair).PairsFieldNames = new string[] { };

            var P_55 = new DeclarationField("P_55", "Kwota do zwrotu na rachunek VAT", DeclarationFieldType.OneOrNull, declaration)
            {
                IsInNestedPair = true,
                IsRequiredInNestedPair = true,
                IsChoicePair = true,
                ChoicePairs = new IFieldMultiplePair[] { P_54 }


            };
            (P_55 as IFieldMultiplePair).IsInPair = true;
            (P_55 as IFieldMultiplePair).PairsFieldNames = new string[] { "P_56", "P_57", "P_58" };
            (P_55 as IFieldMultiplePair).IsRequiredInPair = true;

            var P_56 = new DeclarationField("P_56", "Kwota do zwrotu w terminie 25 dni", DeclarationFieldType.OneOrNull, declaration)
            {
                IsInNestedPair = true,
                IsRequiredInNestedPair = true,
                IsChoicePair = true,
                ChoicePairs = new IFieldMultiplePair[] { P_54 }

            };
            (P_56 as IFieldMultiplePair).IsInPair = true;
            (P_56 as IFieldMultiplePair).PairsFieldNames = new string[] { "P_55", "P_57", "P_58" };
            (P_56 as IFieldMultiplePair).IsRequiredInPair = true;

            var P_57 = new DeclarationField("P_57", "Kwota do zwrotu w terminie 60 dni", DeclarationFieldType.OneOrNull, declaration)
            {
                IsInNestedPair = true,
                IsRequiredInNestedPair = true,
                IsChoicePair = true,
                ChoicePairs = new IFieldMultiplePair[] { P_54 }

            };
            (P_57 as IFieldMultiplePair).IsInPair = true;
            (P_57 as IFieldMultiplePair).PairsFieldNames = new string[] { "P_55", "P_56", "P_58" };
            (P_57 as IFieldMultiplePair).IsRequiredInPair = true;

            var P_58 = new DeclarationField("P_58", "Kwota do zwrotu w terminie 180 dni", DeclarationFieldType.OneOrNull, declaration)
            {
                IsInNestedPair = true,
                IsRequiredInNestedPair = true,
                IsChoicePair = true,
                ChoicePairs = new IFieldMultiplePair[] { P_54 }

            };
            (P_58 as IFieldMultiplePair).IsInPair = true;
            (P_58 as IFieldMultiplePair).PairsFieldNames = new string[] { "P_55", "P_56", "P_57" };
            (P_58 as IFieldMultiplePair).IsRequiredInPair = true;



            var P_59 = new DeclarationField("P_59", "Zaliczenie zwrotu podatku na poczet przyszłych zobowiązań podatkowych", DeclarationFieldType.OneOrNull, declaration)
            {
                IsInNestedPair = true,
                IsRequiredInNestedPair = false,
                IsChoicePair = false,
                Pair = P_55,

            };
            (P_59 as IFieldMultiplePair).IsInPair = true;
            (P_59 as IFieldMultiplePair).PairsFieldNames = new string[] { "P_60", "P_61" };
            (P_59 as IFieldMultiplePair).IsRequiredInPair = true;

            var P_60 = new DeclarationField("P_60", "Wysokość zwrotu do zaliczenia na poczet przyszłych zobowiązań podatkowych", DeclarationFieldType.NullableInt, declaration)
            {
                IsInNestedPair = true,
                IsRequiredInNestedPair = false,
                IsChoicePair = false,
                Pair = P_55
            };

            (P_60 as IFieldMultiplePair).IsInPair = true;
            (P_60 as IFieldMultiplePair).PairsFieldNames = new string[] { "P_59", "P_61" };
            (P_60 as IFieldMultiplePair).IsRequiredInPair = true;

            var P_61 = new DeclarationField("P_61", "Rodzaj przyszłego zobowiązania podatkowego", DeclarationFieldType.NullableInt, declaration)
            {
                IsInNestedPair = true,
                IsRequiredInNestedPair = false,
                IsChoicePair = false,
                Pair = P_55
            };
            (P_61 as IFieldMultiplePair).IsInPair = true;
            (P_61 as IFieldMultiplePair).PairsFieldNames = new string[] { "P_59", "P_60" };
            (P_61 as IFieldMultiplePair).IsRequiredInPair = true;

            P_54.ChoicePairs = new IFieldMultiplePair[] { P_55, P_56, P_57, P_58 };
            P_54.Pair = P_59;
            P_55.Pair = P_59;
            P_56.Pair = P_59;
            P_57.Pair = P_59;
            P_58.Pair = P_59;
            declaration.Declarations.Add(P_54);
            declaration.Declarations.Add(P_55);
            declaration.Declarations.Add(P_56);
            declaration.Declarations.Add(P_57);
            declaration.Declarations.Add(P_58);
            declaration.Declarations.Add(P_59);
            declaration.Declarations.Add(P_60);
            declaration.Declarations.Add(P_61);



            declaration.Declarations.Add(new DeclarationField("P_62", "Kwota do przeniesienia na następny okres rozliczeniowy", DeclarationFieldType.NullableInt, declaration));

            declaration.Declarations.Add(new DeclarationField("P_63", "Czynności jakie wykonywał podatnik - art.119 ustawy", DeclarationFieldType.OneOrNull, declaration));
            declaration.Declarations.Add(new DeclarationField("P_64", "Czynności jakie wykonywał podatnik - art.120 ust.4 lub 5 ustawy", DeclarationFieldType.OneOrNull, declaration));
            declaration.Declarations.Add(new DeclarationField("P_65", "Czynności jakie wykonywał podatnik - art.122 ustawy", DeclarationFieldType.OneOrNull, declaration));
            declaration.Declarations.Add(new DeclarationField("P_66", "Czynności jakie wykonywał podatnik - art.136 ustawy", DeclarationFieldType.OneOrNull, declaration));
            declaration.Declarations.Add(new DeclarationField("P_67", "Podatnik korzysta z obniżenia zobowiązania podatkowego", DeclarationFieldType.OneOrNull, declaration));

            declaration.Declarations.Add(new DeclarationField("P_68", "Wysokość korekty podstawy opodatkowania, o której mowa w art. 89a ust. 1 ustawy", DeclarationFieldType.NegativeOrZeroOrNull, declaration, true, true, "P_69"));
            declaration.Declarations.Add(new DeclarationField("P_69", "Wysokość korekty podatku należnego, o której mowa w art. 89a ust. 1 ustawy", DeclarationFieldType.NullableInt, declaration, true, true, "P_68"));

            declaration.Declarations.Add(new DeclarationField("P_ORDZU", "Uzasadnienie przyczyn złożenia korekty", DeclarationFieldType.String, declaration));


        }



        #endregion

        #region utilities

        private static T DeserializeObject<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            return (T)serializer.Deserialize(fs);
        }

        private static void SerializeObject<T>(string path, T t)
        {

            var serializer = new XmlSerializer(typeof(T));
            using var fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
            serializer.Serialize(fs, t);
        }

        private static async Task<T> TryToDeserializeObjectAsync<T>(string path)
        {
            try
            {
                return await Task.Run(() => DeserializeObject<T>(path));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private static async Task TryToSerializeObjectAsync<T>(string path, T t)
        {
            try
            {
                await Task.Run(() => SerializeObject(path, t));
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion
    }
}
