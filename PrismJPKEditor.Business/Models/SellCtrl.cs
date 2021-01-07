using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PrismJPKEditor.Business.Models
{
    public class SellCtrl : BusinessBase, INotifyDataErrorInfo
    {
        #region private members

        private int liczbaWierszySprzedazyField;
        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();
        private decimal podatekNaleznyField;

        #endregion

        #region public properties

        /// <remarks/>
        public int LiczbaWierszySprzedazy
        {
            get
            {
                return this.liczbaWierszySprzedazyField;
            }
            set
            {
                SetProperty(ref liczbaWierszySprzedazyField, value);
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
              
                SetProperty(ref podatekNaleznyField, value);
                ValidatePodatekNalezny();
            }
        }


        public Sell Sell { get; set; }
        #endregion

        #region iNotifyDataError

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public override bool HasErrors => _errorsByPropertyName.Any();



        public IEnumerable GetErrors(string propertyName)
        {
            return _errorsByPropertyName.ContainsKey(propertyName) ?
            _errorsByPropertyName[propertyName] : null;           
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        private void AddError(string propertyName, string error)
        {
            if (!_errorsByPropertyName.ContainsKey(propertyName))
                _errorsByPropertyName[propertyName] = new List<string>();

            if (!_errorsByPropertyName[propertyName].Contains(error))
            {
                _errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        private void ClearErrors(string propertyName, string error)
        {
            if (_errorsByPropertyName.ContainsKey(propertyName))
            {
                var list = _errorsByPropertyName[propertyName];
                list.Remove(error);

                if (list.Count == 0)
                {
                    _errorsByPropertyName.Remove(propertyName);
                }

                OnErrorsChanged(propertyName);
            }
        }

        #endregion

        #region constructors
        public SellCtrl()
        {

        }
        #endregion

        #region validate methods

        public void ValidatePodatekNalezny()
        {
            if (Sell == null)
                return;

            var k_16Sum = Sell.SellRows.Sum(sr => sr.K_16);
            var k_18Sum = Sell.SellRows.Sum(sr => sr.K_18);
            var k_20Sum = Sell.SellRows.Sum(sr => sr.K_20);
            var k_24Sum = Sell.SellRows.Sum(sr => sr.K_24);
            var k_26Sum = Sell.SellRows.Sum(sr => sr.K_26);
            var k_28Sum = Sell.SellRows.Sum(sr => sr.K_28);
            var k_30Sum = Sell.SellRows.Sum(sr => sr.K_30);
            var k_32Sum = Sell.SellRows.Sum(sr => sr.K_32);
            var k_33Sum = Sell.SellRows.Sum(sr => sr.K_33);
            var k_34Sum = Sell.SellRows.Sum(sr => sr.K_34);

            var sumOfKSums = k_16Sum + k_18Sum + k_20Sum + k_24Sum + k_26Sum + k_28Sum + k_30Sum + k_32Sum + k_33Sum + k_34Sum;

            var k_35Sum = Sell.SellRows.Sum(sr => sr.K_35);
            var k_36Sum = Sell.SellRows.Sum(sr => sr.K_36);

            var substractSum = k_35Sum + k_36Sum;

            var result = sumOfKSums - substractSum;

            if (PodatekNalezny != result && PodatekNalezny != decimal.Parse("0,00"))
            {
                AddError(nameof(PodatekNalezny), $"Wyliczalna suma nie zgadza sie. Powinno wyjsc {result}");
            }
            else
            {
                ClearErrors(nameof(PodatekNalezny), $"Wyliczalna suma nie zgadza sie. Powinno wyjsc {result}");
            }

        }

        #endregion

        

    }
}
