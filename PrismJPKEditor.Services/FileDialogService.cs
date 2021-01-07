using PrismJPKEditor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PrismJPKEditor.Services
{
    public class FileDialogService : IFileDialogService
    {
        public bool OpenFile(out string path)
        {
            path = string.Empty;
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files(*.xml)| *.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public bool SaveFile(out string path)
        {
            path = string.Empty;
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files(*.xml)| *.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                return true;
            }
            return false;
        }
    }
}
