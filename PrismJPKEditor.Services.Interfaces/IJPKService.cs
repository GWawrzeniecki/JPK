using PrismJPKEditor.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrismJPKEditor.Services.Interfaces
{
    public interface IJPKService
    {
        public Task LoadDBAsync(string path);
        public Task SaveAsync(string path);
        public Task SaveAsAsync(string path);
    }
}
