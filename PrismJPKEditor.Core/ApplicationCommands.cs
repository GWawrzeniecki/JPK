using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

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
