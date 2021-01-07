using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Business
{
    public interface IFieldMultiplePair
    {
        bool IsInPair { get; set; }
        bool IsRequiredInPair { get; set; }
        string[] PairsFieldNames { get; set; }


        void ValidateMultiplePair();
        void RevalidateMultiplePair();
    }
}
