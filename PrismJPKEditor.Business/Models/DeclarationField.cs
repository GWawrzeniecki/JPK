using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PrismJPKEditor.Business.Models
{
    public enum DeclarationFieldType { NullableInt, String, NegativeOrZeroOrNull, IntOrZero, Calculable, OneOrNull };

    public class DeclarationField : BusinessBase, INotifyDataErrorInfo, IFieldDoublePair, IFieldNestedMultiplePair
    {
        #region private Members
        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();

        #endregion

        #region public properties

        public string Description { get; set; }

        public DeclarationFieldType ValueType { get; private set; }

        public bool HasValue => !(XMLValue == null);


        private object _value;

        /// <summary>
        /// P_10
        /// </summary>
        public string FieldName { get; set; }

        public object GridValue
        {
            get
            {
                return _value;
            }
            set
            {
                SetProperty(ref _value, value);
                Validation(value);
                ValidateDoublePair();
                RevalidateDoublePair();
                (this as IFieldMultiplePair).ValidateMultiplePair();
                (this as IFieldNestedMultiplePair).ValidateNestedMultiplePair();
                (this as IFieldMultiplePair).RevalidateMultiplePair();
                (this as IFieldNestedMultiplePair).ReValidateNestedMultiplePair();
            }
        }

        public object XMLValue
        {
            get
            {
                if (ValueType == DeclarationFieldType.String)
                {

                    return GridValue?.ToString() ?? null;
                }
                else
                {
                    if (int.TryParse(GridValue?.ToString(), out int result))
                    {
                        return result;
                    }
                    else
                    {
                        int? val = null;
                        return val;
                    }
                }
            }
        }

        public Declaration Declaration { get; private set; }

        #endregion

        #region constructors

      
        public DeclarationField(string fieldName, string description, DeclarationFieldType declarationFieldType,
            Declaration declaration, bool isInPair = false, bool isRequiredInPair = false, string pairFieldName = "", bool isPairRequired = false)
        {
            FieldName = fieldName;
            Description = description;
            ValueType = declarationFieldType;
            Declaration = declaration;
            IsInPair = isInPair;
            IsRequiredInPair = isRequiredInPair;
            PairFieldName = pairFieldName;
            IsPairRequired = isPairRequired;
        }



        #endregion

        #region iNotifyError region

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

        #region validation methods

        public void ValidateInt(object value, string error = "Wartość musi być liczbą")
        {
            ClearErrors(nameof(GridValue), error);
            if (!int.TryParse(value?.ToString(), out int result))
                AddError(nameof(GridValue), error);
        }

        public void ValidateBool(object value)
        {
            var msg = "Wartość musi wynosić 0 albo 1";
            ClearErrors(nameof(GridValue), msg);
            if (!bool.TryParse(value?.ToString(), out bool result))
                AddError(nameof(GridValue), msg);
        }

        public void ValidateString(object value)
        {
            // ClearErrors(nameof(FieldName)); //Validating string? can be empty


        }


        public void ValidateNullableInt(object value)
        {
            var msg = "Wartość musi być liczbą lub musi pozostać pusta";
            ClearErrors(nameof(GridValue), msg);
            if (!string.IsNullOrEmpty(value?.ToString()))
                ValidateInt(value, msg);
        }

        public void ValidateNegativeOrZeroOrNull(object value)
        {
            // To do przerobić 
            var msg1 = "Wartość musi być mniejsza bądź równa 0";
            var msg2 = "Wartość musi być liczbą mniejszą bądź równą 0 lub pozostać pusta";
            ClearErrors(nameof(GridValue), msg1);
            ClearErrors(nameof(GridValue), msg2);


            if (!string.IsNullOrEmpty(value?.ToString()))
            {
                if (int.TryParse(value.ToString(), out int result))
                {
                    if (result > 0)
                        AddError(nameof(GridValue), msg1);
                }
                else
                {
                    AddError(nameof(GridValue), msg2);
                }
            }

        }

        public void ValidateIntOrZero(object value)
        {
            // To do przerobić 
            var msg1 = "W przypadku braku wartości należy wpisać 0.";
            var msg2 = "Wartość musi być liczbą. W przypadku braku wartości należy wstawić 0.";
            ClearErrors(nameof(GridValue), msg1);
            ClearErrors(nameof(GridValue), msg2);

            if (string.IsNullOrEmpty(value?.ToString()))
            {
                AddError(nameof(GridValue), msg1);
            }
            else
            {
                if (int.TryParse(value.ToString(), out int result))
                {

                }
                else
                {
                    AddError(nameof(GridValue), msg2);
                }
            }
        }

        public void ValidateOneOrNull(object value)
        {
            var msg1 = "Wartość musi wynosić 1 lub pozostać pusta.";
            var msg2 = "Wartość musi być liczbą większą rowną 0 lub pozostać pusta";
            ClearErrors(nameof(GridValue), msg1);
            ClearErrors(nameof(GridValue), msg2);

            if (!string.IsNullOrEmpty(value?.ToString()))
            {
                if (int.TryParse(value.ToString(), out int result))
                {
                    if (result != 1)
                        AddError(nameof(GridValue), msg1);
                }
                else
                {
                    AddError(nameof(GridValue), msg2);
                }
            }
        }

        public void ValidateCalculable(object value)
        {
            switch (FieldName)
            {
                case "P_37":
                    {
                        var msg1 = "Wartość wyliczalna musi się zgadzać lub musi pozostać pusta.";
                        var msg2 = "Wartość wyliczalna musi się zgadzać lub musi pozostać pusta.";
                        ClearErrors(nameof(GridValue), msg1);
                        ClearErrors(nameof(GridValue), msg2);
                        var dic = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i);
                        var list = new List<DeclarationField>
                    {
                        dic["P_10"],
                        dic["P_11"],
                        dic["P_13"],
                        dic["P_15"],
                        dic["P_17"],
                        dic["P_19"],
                        dic["P_21"],
                        dic["P_22"],
                        dic["P_23"],
                        dic["P_25"],
                        dic["P_27"],
                        dic["P_29"],
                        dic["P_31"]
                    };
                        var sum = list.Sum(f => string.IsNullOrEmpty(f.GridValue?.ToString()) ? 0 : int.Parse(f.GridValue.ToString()));


                        if (!string.IsNullOrEmpty(value.ToString()))
                        {

                            if (int.TryParse(value?.ToString(), out int i))
                            {
                                if (sum != i)
                                    AddError(nameof(GridValue), msg1);
                            }
                            else
                            {
                                AddError(nameof(GridValue), msg2);
                            }
                        }
                    }
                    break;
                case "P_38":
                    {
                        var msg1 = "Wartość wyliczalna nie zgadza się.";
                        var msg2 = "Wartość wyliczalna musi się zgadzać lub musi być równa 0.";
                        var msg3 = "W przypadku braku wartości należy wykazać 0.";

                        ClearErrors(nameof(GridValue), msg1);
                        ClearErrors(nameof(GridValue), msg2);
                        ClearErrors(nameof(GridValue), msg3);
                        var dic = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i);
                        var addList = new List<DeclarationField>
                    {
                        dic["P_16"],
                        dic["P_18"],
                        dic["P_20"],
                        dic["P_24"],
                        dic["P_26"],
                        dic["P_28"],
                        dic["P_30"],
                        dic["P_32"],
                        dic["P_33"],
                        dic["P_34"]
                    };

                        var substractList = new List<DeclarationField>
                    {
                        dic["P_35"],
                        dic["P_36"]
                    };

                        var addSum = addList.Sum(f => string.IsNullOrEmpty(f.GridValue?.ToString()) ? 0 : int.Parse(f.GridValue.ToString()));
                        var substractSum = substractList.Sum(f => string.IsNullOrEmpty(f.GridValue?.ToString()) ? 0 : int.Parse(f.GridValue.ToString()));
                        var fieldValue = addSum - substractSum;

                        if (!string.IsNullOrEmpty(value?.ToString()))
                        {

                            if (int.TryParse(value?.ToString(), out int i))
                            {
                                if (i != fieldValue && i != 0)
                                    AddError(nameof(GridValue), msg1);
                            }
                            else
                            {
                                AddError(nameof(GridValue), msg2);
                            }
                        }
                        else
                        {
                            AddError(nameof(GridValue), msg3);
                        }
                    }
                    break;
                case "P_48":
                    {
                        var msg1 = "Wartość wyliczalna musi się zgadzać lub musi pozostać pusta.";
                        var msg2 = "Wartość wyliczalna musi się zgadzać lub musi pozostać pusta.";
                        ClearErrors(nameof(GridValue), msg1);
                        ClearErrors(nameof(GridValue), msg2);
                        var dic = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i);
                        var list = new List<DeclarationField>
                    {
                        dic["P_39"],
                        dic["P_41"],
                        dic["P_43"],
                        dic["P_44"],
                        dic["P_45"],
                        dic["P_46"],
                        dic["P_47"]

                    };
                        var sum = list.Sum(f => string.IsNullOrEmpty(f.GridValue?.ToString()) ? 0 : int.Parse(f.GridValue.ToString()));

                        if (!string.IsNullOrEmpty(value.ToString()))
                        {

                            if (int.TryParse(value?.ToString(), out int i))
                            {
                                if (sum != i)
                                    AddError(nameof(GridValue), msg1);
                            }
                            else
                            {
                                AddError(nameof(GridValue), msg2);
                            }
                        }
                    }
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        private void Validation(object value)
        {
            switch (ValueType)
            {
                case DeclarationFieldType.String:
                    ValidateString(value);
                    break;
                case DeclarationFieldType.NullableInt:
                    ValidateNullableInt(value);
                    break;
                case DeclarationFieldType.NegativeOrZeroOrNull:
                    ValidateNegativeOrZeroOrNull(value);
                    break;
                case DeclarationFieldType.IntOrZero:
                    ValidateIntOrZero(value);
                    break;
                case DeclarationFieldType.Calculable:
                    ValidateCalculable(value);
                    break;
                case DeclarationFieldType.OneOrNull:
                    ValidateOneOrNull(value);
                    break;
                default:
                    throw new Exception();
            }
        }



        #endregion

        #region IFieldDoublePair 

        public bool IsInPair { get; set; }
        public string PairFieldName { get; set; }
        public bool IsRequiredInPair { get; set; }
        public bool IsPairRequired { get; set; }


        public void ValidateDoublePair()
        {
            if (!(IsInPair))
                return;

            var pair = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i)[PairFieldName];

            if (IsRequiredInPair && pair.IsRequiredInPair)
            {
                if (IsPairRequired)
                {
                    if (!HasValue)
                    {
                        AddError(nameof(GridValue), $"{FieldName} jest w parze z {pair.FieldName} a nie ma wpisanej wartości");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"{FieldName} jest w parze z {pair.FieldName} a nie ma wpisanej wartości");
                    }

                    if (!pair.HasValue)
                    {
                        AddError(nameof(GridValue), $"{pair.FieldName} jest w parze z {FieldName} a nie ma wpisanej wartości");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"{pair.FieldName} jest w parze z {FieldName} a nie ma wpisanej wartości");
                    }

                    if (!HasValue && !pair.HasValue)
                    {
                        AddError(nameof(GridValue), $"Pole {FieldName} i pole {pair.FieldName} nie mają wartości a są parą wymaganą");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"Pole {FieldName} i pole {pair.FieldName} nie mają wartości a są parą wymaganą");
                    }
                }
                else
                {
                    if (!HasValue && pair.HasValue)
                    {
                        AddError(nameof(GridValue), $"{FieldName} jest w parze z {pair.FieldName} a nie ma wpisanej wartości");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"{FieldName} jest w parze z {pair.FieldName} a nie ma wpisanej wartości");
                    }

                    if (HasValue && !pair.HasValue)
                    {
                        AddError(nameof(GridValue), $"{pair.FieldName} jest w parze z {FieldName} a nie ma wpisanej wartości");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"{pair.FieldName} jest w parze z {FieldName} a nie ma wpisanej wartości");
                    }
                }



            }
            else if (IsRequiredInPair && !pair.IsRequiredInPair)
            {
                if (IsPairRequired)
                {

                    if (pair.HasValue && !HasValue)
                    {
                        AddError(nameof(GridValue), $"{FieldName} jest w parze z {pair.FieldName} a nie ma wpisanej wartości");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"{FieldName} jest w parze z {pair.FieldName} a nie ma wpisanej wartości");
                    }

                    if (!HasValue && !pair.HasValue)
                    {
                        AddError(nameof(GridValue), $"pole {FieldName} nie ma wartości a jest w parze wymaganej");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"pole {FieldName} nie ma wartości a jest w parze wymaganej");
                    }
                }
                else
                {
                    if (pair.HasValue && !HasValue)
                    {
                        AddError(nameof(GridValue), $"{FieldName} jest w parze z {pair.FieldName} a nie ma wpisanej wartości");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"{FieldName} jest w parze z {pair.FieldName} a nie ma wpisanej wartości");
                    }
                }
            }
            else if (!IsRequiredInPair && pair.IsRequiredInPair)
            {
                if (IsPairRequired)
                {

                    if (!pair.HasValue && HasValue)
                    {
                        AddError(nameof(GridValue), $"{pair.FieldName} jest w parze z {FieldName} a nie ma wpisanej wartości");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"{pair.FieldName} jest w parze z {FieldName} a nie ma wpisanej wartości");
                    }

                    if (!pair.HasValue && !pair.HasValue && pair.IsPairRequired)
                    {
                        AddError(nameof(GridValue), $"Pole {pair.FieldName} nie ma wartości a jest w parze wymaganej");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"Pole {pair.FieldName} nie ma wartości a jest w parze wymaganej");
                    }
                }
                else
                {
                    if (!pair.HasValue && HasValue)
                    {
                        AddError(nameof(GridValue), $"{pair.FieldName} jest w parze z {FieldName} a nie ma wpisanej wartości");
                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"{pair.FieldName} jest w parze z {FieldName} a nie ma wpisanej wartości");
                    }
                }
            }
            else
            {
                throw new Exception("Something went wrong");
            }


        }

        public void RevalidateDoublePair()
        {

            if (!(IsInPair))
                return;

            var pair = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i)[PairFieldName];

            pair.ValidateDoublePair();
        }



        #endregion

        #region IFieldNestedMultiplePair

        bool IFieldMultiplePair.IsInPair { get; set; }
        bool IFieldMultiplePair.IsRequiredInPair { get; set; }
        string[] IFieldMultiplePair.PairsFieldNames { get; set; }

        public bool IsRequiredInNestedPair { get; set; }
        public bool IsChoicePair { get; set; }
        public IFieldMultiplePair[] ChoicePairs { get; set; }
        public IFieldNestedMultiplePair Pair { get; set; }
        public bool IsInNestedPair { get; set; }


        void IFieldNestedMultiplePair.ValidateNestedMultiplePair()
        {
            var iFieldMultiplePair = this as IFieldNestedMultiplePair;

            if (!iFieldMultiplePair.IsInNestedPair)
                return;

            var dic = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i);
            var pairs = new List<IFieldMultiplePair>();

            foreach (var pairName in iFieldMultiplePair.PairsFieldNames)
            {
                pairs.Add(dic[pairName]);

            }

            var AllPairs = new List<IFieldMultiplePair>(pairs)
            {
                this
            };

            var pairPairs = new List<IFieldMultiplePair>();

            foreach (var pairName in iFieldMultiplePair.Pair.PairsFieldNames)
            {
                pairPairs.Add(dic[pairName]);

            }

            var AllPairPairs = new List<IFieldMultiplePair>(pairPairs)
            {
                iFieldMultiplePair.Pair
            };

            if (iFieldMultiplePair.IsRequiredInNestedPair && !iFieldMultiplePair.Pair.IsRequiredInNestedPair)
            {
                if (AllPairPairs.Any(p => (p as DeclarationField).HasValue))
                {
                    if (iFieldMultiplePair.IsChoicePair)
                    {
                        var choicePairPairs = new List<IFieldMultiplePair>();

                        foreach (DeclarationField field in iFieldMultiplePair.ChoicePairs)
                        {
                            choicePairPairs.Add(dic[field.FieldName]);
                        }
                        //Jesli w kazdej parze nie wszystkie pola maja wartosci a wszystkie sa wymagane
                        if (AllPairs.Any(p => !(p as DeclarationField).HasValue) && AllPairs.All(p => (p as DeclarationField).IsRequiredInNestedPair) && choicePairPairs.Any(p => !(p as DeclarationField).HasValue) && choicePairPairs.All(p => (p as DeclarationField).IsRequiredInNestedPair))
                        {
                            AddError(nameof(GridValue), $"Pola: {string.Join(',', AllPairs.Select(p => (p as DeclarationField).FieldName))} lub pola:  {string.Join(',', choicePairPairs.Select(p => (p as DeclarationField).FieldName))} są w parze z polami: {string.Join(',', AllPairPairs.Select(p => (p as DeclarationField).FieldName))} które muszą zostać wypełnione jeśli te drugie są wypełnione.");
                        }
                        else
                        {
                            ClearErrors(nameof(GridValue), $"Pola: {string.Join(',', AllPairs.Select(p => (p as DeclarationField).FieldName))} lub pola:  {string.Join(',', choicePairPairs.Select(p => (p as DeclarationField).FieldName))} są w parze z polami: {string.Join(',', AllPairPairs.Select(p => (p as DeclarationField).FieldName))} które muszą zostać wypełnione jeśli te drugie są wypełnione.");
                        }
                    }
                    else
                    {
                        if (AllPairs.Any(p => !(p as DeclarationField).HasValue))
                        {
                            AddError(nameof(GridValue), $"Pola: {string.Join(',', AllPairs.Select(p => (p as DeclarationField).FieldName))} są w parze z polami: {string.Join(',', AllPairPairs.Select(p => (p as DeclarationField).FieldName))} które muszą zostać wypełnione. Jeśli te pierwsze są wypełnione");
                        }
                        else
                        {
                            ClearErrors(nameof(GridValue), $"Pola: {string.Join(',', AllPairs.Select(p => (p as DeclarationField).FieldName))} są w parze z polami: {string.Join(',', AllPairPairs.Select(p => (p as DeclarationField).FieldName))} które muszą zostać wypełnione. Jeśli te pierwsze są wypełnione");
                        }
                    }
                }
                else
                {
                    var choicePairPairs = new List<IFieldMultiplePair>();

                    foreach (DeclarationField field in iFieldMultiplePair.ChoicePairs)
                    {
                        choicePairPairs.Add(dic[field.FieldName]);
                    }

                    if (iFieldMultiplePair.IsChoicePair)
                    {
                        ClearErrors(nameof(GridValue), $"Pola: {string.Join(',', AllPairs.Select(p => (p as DeclarationField).FieldName))} lub pola:  {string.Join(',', choicePairPairs.Select(p => (p as DeclarationField).FieldName))} są w parze z polami: {string.Join(',', AllPairPairs.Select(p => (p as DeclarationField).FieldName))} które muszą zostać wypełnione jeśli te drugie są wypełnione.");
                    }
                    else
                    {
                        //narazie nie ma takiego przypadku
                    }
                }
            }
            else if (!iFieldMultiplePair.IsRequiredInNestedPair && iFieldMultiplePair.Pair.IsRequiredInNestedPair)
            {
                if (iFieldMultiplePair.Pair.IsChoicePair)
                {
                    var choicePairPairs = new List<IFieldMultiplePair>();

                    foreach (DeclarationField field in iFieldMultiplePair.Pair.ChoicePairs)
                    {
                        choicePairPairs.Add(dic[field.FieldName]);
                    }

                    if (AllPairs.Any(p => (p as DeclarationField).HasValue))
                    {

                        if (!AllPairPairs.All(p => (p as DeclarationField).HasValue) && !choicePairPairs.All(p => (p as DeclarationField).HasValue))
                        {
                            AddError(nameof(GridValue), $"Pola: {string.Join(',', AllPairs.Select(p => (p as DeclarationField).FieldName))}  są w parze z polami: {string.Join(',', AllPairPairs.Select(p => (p as DeclarationField).FieldName))}  lub z polami: {string.Join(',', choicePairPairs.Select(p => (p as DeclarationField).FieldName))} które muszą zostać wypełnione jeśli te pierwsze są wypełnione.");
                        }
                        else
                        {
                            ClearErrors(nameof(GridValue), $"Pola: {string.Join(',', AllPairs.Select(p => (p as DeclarationField).FieldName))}  są w parze z polami: {string.Join(',', AllPairPairs.Select(p => (p as DeclarationField).FieldName))}  lub z polami: {string.Join(',', choicePairPairs.Select(p => (p as DeclarationField).FieldName))} które muszą zostać wypełnione jeśli te pierwsze są wypełnione.");
                        }


                    }
                    else
                    {
                        ClearErrors(nameof(GridValue), $"Pola: {string.Join(',', AllPairs.Select(p => (p as DeclarationField).FieldName))}  są w parze z polami: {string.Join(',', AllPairPairs.Select(p => (p as DeclarationField).FieldName))}  lub z polami: {string.Join(',', choicePairPairs.Select(p => (p as DeclarationField).FieldName))} które muszą zostać wypełnione jeśli te pierwsze są wypełnione.");
                    }
                }
                else
                {
                    //narazie nie mamy takiego przypadku
                }
            }
        }

        public void ReValidateNestedMultiplePair()
        {
            var fieldNestedMultiplePair = this as IFieldNestedMultiplePair;
            if (!fieldNestedMultiplePair.IsInNestedPair)
                return;

            var dic = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i);

            var allPairPairs = new List<IFieldNestedMultiplePair>();

            foreach (var pairName in fieldNestedMultiplePair.PairsFieldNames)
            {
                (dic[pairName] as IFieldNestedMultiplePair).ValidateNestedMultiplePair();
            }

            foreach (var pairName in fieldNestedMultiplePair.Pair.PairsFieldNames)
            {
                allPairPairs.Add(dic[pairName]);
            }

            allPairPairs.Add(fieldNestedMultiplePair.Pair);

            foreach (var pair in allPairPairs)
            {
                pair.ValidateNestedMultiplePair();
            }

            if (fieldNestedMultiplePair.IsChoicePair)
            {
                foreach (var choicePairs in fieldNestedMultiplePair.ChoicePairs)
                {
                    (choicePairs as IFieldNestedMultiplePair).ValidateNestedMultiplePair();
                }
            }
            else
            {
                if (fieldNestedMultiplePair.Pair.IsChoicePair)
                {
                    foreach (var choicePairs in fieldNestedMultiplePair.Pair.ChoicePairs)
                    {
                        (choicePairs as IFieldNestedMultiplePair).ValidateNestedMultiplePair();
                    }
                }
            }




        }

        void IFieldMultiplePair.ValidateMultiplePair()
        {
            var iFieldMultiplePair = this as IFieldMultiplePair;

            if (!iFieldMultiplePair.IsInPair)
                return;

            var dic = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i);


            // Loading pairs

            var pairs = new List<IFieldMultiplePair>();

            foreach (var pairName in iFieldMultiplePair.PairsFieldNames)
            {
                pairs.Add(dic[pairName]);

            }

            var AllPairs = new List<IFieldMultiplePair>(pairs)
            {
                this
            };

            //jesli wszystkie sa wymagane i ktoras ma wartosc ale nie wszystkie to blad
            if (AllPairs.All(p => p.IsRequiredInPair) && AllPairs.Any(p => (p as DeclarationField).HasValue) && !AllPairs.All(p => (p as DeclarationField).HasValue))
            {
                AddError(nameof(GridValue), $"Pole {FieldName} jest w parze z polami: {string.Join(',', pairs.Select(p => (p as DeclarationField).FieldName))} gdzie każde pole musi mieć przypisaną wartość");
            }
            else
            {
                ClearErrors(nameof(GridValue), $"Pole {FieldName} jest w parze z polami: {string.Join(',', pairs.Select(p => (p as DeclarationField).FieldName))} gdzie każde pole musi mieć przypisaną wartość");
            }
            // jesli jakas z nie wymaganych ma wartosc a ktoas z wymaganych nie ma wartosci to blad
            if (AllPairs.Where(p => !p.IsRequiredInPair).Any(p => (p as DeclarationField).HasValue) && AllPairs.Where(p => p.IsRequiredInPair).Any(p => !(p as DeclarationField).HasValue))
            {
                AddError(nameof(GridValue), $"Pole {FieldName} jest w parze z polami: {string.Join(',', pairs.Select(p => (p as DeclarationField).FieldName))}  gdzie jesli któreś z pól: " +
                    $"{string.Join(',', AllPairs.Where(p => !p.IsRequiredInPair).Select(p => (p as DeclarationField).FieldName))} ma wartość to pola:" +
                    $"{string.Join(',', AllPairs.Where(p => p.IsRequiredInPair).Select(p => (p as DeclarationField).FieldName))} też muszą mieć wartość.");
            }
            else
            {
                ClearErrors(nameof(GridValue), $"Pole {FieldName} jest w parze z polami: {string.Join(',', pairs.Select(p => (p as DeclarationField).FieldName))}  gdzie jesli któreś z pól: " +
                    $"{string.Join(',', AllPairs.Where(p => !p.IsRequiredInPair).Select(p => (p as DeclarationField).FieldName))} ma wartość to pola:" +
                    $"{string.Join(',', AllPairs.Where(p => p.IsRequiredInPair).Select(p => (p as DeclarationField).FieldName))} też muszą mieć wartość.");
            }

        }

        public void RevalidateMultiplePair()
        {
            var fieldMultiplePair = this as IFieldMultiplePair;
            if (!fieldMultiplePair.IsInPair)
                return;

            var dic = Declaration.Declarations.ToDictionary(i => i.FieldName, i => i);

            foreach (var pairName in fieldMultiplePair.PairsFieldNames)
            {
                (dic[pairName] as IFieldMultiplePair).ValidateMultiplePair();
            }
        }









        #endregion
    }
}
