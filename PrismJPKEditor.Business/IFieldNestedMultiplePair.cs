using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Business
{
    public interface IFieldNestedMultiplePair : IFieldMultiplePair
    {
        bool IsInNestedPair { get; set; }
        bool IsRequiredInNestedPair { get; set; }
        bool IsChoicePair { get; set; }
        IFieldMultiplePair[] ChoicePairs { get; set; }
        IFieldNestedMultiplePair Pair { get; set; }


        void ValidateNestedMultiplePair();
        void ReValidateNestedMultiplePair();

    }
}
