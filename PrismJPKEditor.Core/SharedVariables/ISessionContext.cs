namespace PrismJPKEditor.Core.SharedVariables
{
    public interface ISessionContext
    {
        public Business.Models.JPK JPKDataSource { get; set; }
        public bool HasErrors { get; }
    }
}
