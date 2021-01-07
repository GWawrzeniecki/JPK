namespace PrismJPKEditor.Business
{
    public interface IFieldDoublePair
    {
        public bool IsInPair { get; set; }
        public string PairFieldName { get; set; }
        public bool IsRequiredInPair { get; set; }
        public bool IsPairRequired { get; set; }

        void ValidateDoublePair();
        void RevalidateDoublePair();

    }
}
