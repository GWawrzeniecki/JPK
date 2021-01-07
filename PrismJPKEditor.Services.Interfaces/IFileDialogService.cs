using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Services.Interfaces
{
    public interface IFileDialogService
    {
        public bool OpenFile(out string path);
        public bool SaveFile(out string path);

    }
}
