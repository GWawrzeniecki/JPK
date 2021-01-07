using Prism.Commands;

namespace PrismJPKEditor.Core
{
    public interface IApllicationCommands
    {
        CompositeCommand NavigateCommand { get; }
    }

    public class ApplicationCommands : IApllicationCommands
    {
        public CompositeCommand NavigateCommand { get; } = new CompositeCommand();
    }
}
