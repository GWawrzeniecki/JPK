using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismJPKEditor.Core.Dialogs;
using PrismJPKEditor.Core.SharedVariables;
using PrismJPKEditor.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PrismJPKEditor.Modules.TaskBar.ViewModels
{
    public class TaskBarViewModel : BindableBase
    {
        private readonly IJPKService _jpkService;
        private readonly IFileDialogService _fileDialogService;
        private readonly ISessionContext _sessionContext;
        private readonly IDialogService _dialogService;

        public string FilePath { get; private set; }

        public DelegateCommand OpenFileDialogCommand { get; private set; }
        public DelegateCommand SaveCommand { get; private set; }
        public DelegateCommand SaveAsCommand { get; private set; }


        public TaskBarViewModel(IJPKService jPKService, IFileDialogService fileDialogService, ISessionContext sessionContext, IDialogService dialogService)
        {
            this._jpkService = jPKService;
            this._fileDialogService = fileDialogService;
            this._sessionContext = sessionContext;
            this._dialogService = dialogService;
            OpenFileDialogCommand = new DelegateCommand(TryToOpenFileDialogAsync);
            SaveCommand = new DelegateCommand(TryToSaveAsync);
            SaveAsCommand = new DelegateCommand(TryToSaveAsAsync);
        }

        #region commands methods

        private async void TryToOpenFileDialogAsync()
        {
            try
            {
                await OpenFileDialogAsync();
            }
            catch (Exception e)
            {
                _dialogService.ShowNotificationDialog($"Wystąpił błąd podczas ładowania pliku JKP.{Environment.NewLine}Błąd: {e.Message}", null);
            }
        }

        private async void TryToSaveAsync()
        {
            try
            {
                await SaveAsync();
            }
            catch (Exception e)
            {
                _dialogService.ShowNotificationDialog($"Wystąpił błąd podczas zapisywania zmian w pliku JKP.{Environment.NewLine}Błąd: {e.Message}", null);
            }
        }


        private async void TryToSaveAsAsync()
        {
            try
            {
                await SaveAsAsync();
            }
            catch (Exception e)
            {
                _dialogService.ShowNotificationDialog($"Wystąpił błąd podczas zapisywania JPK do pliku.{Environment.NewLine}Błąd: {e.Message}", null);
            }
        }

        #endregion

        #region private methods
        private async Task OpenFileDialogAsync()
        {
            if (_fileDialogService.OpenFile(out string path))
            {
                FilePath = path;
                await _jpkService.LoadDBAsync(path);
            }
        }

        private async Task SaveAsync()
        {

            if (string.IsNullOrEmpty(FilePath))
                return;

            if (IsSave())
            {

                await _jpkService.SaveAsync(FilePath);
                _dialogService.ShowNotificationDialog("Zmiany zostały zapisane pomyślnie.", null);
            }

        }

        private async Task SaveAsAsync()
        {
            if (string.IsNullOrEmpty(FilePath))
                return;

            if (IsSave())
            {

                if (_fileDialogService.SaveFile(out string path))
                {
                    //FilePath = path;
                    await _jpkService.SaveAsAsync(path);
                    _dialogService.ShowNotificationDialog("Plik został zapisany pomyślnie.", null);
                }
            }
        }


        private bool IsSave() //To do checking the sell and buy
        {
            var saveDecision = false;
            if (!_sessionContext.HasErrors)
            {
                saveDecision = true;
            }
            else
            {
                _dialogService.ShowYesNoDialog("Istnieja błędne rekordy. Czy chcesz zapisac pomimo tego?", r =>
                {
                    if (r.Result == ButtonResult.Yes)
                    {
                        saveDecision = true;
                    }

                });
            }

            return saveDecision;
        }

        #endregion


    }
}
