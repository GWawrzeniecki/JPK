using Prism.Services.Dialogs;
using System;

namespace PrismJPKEditor.Core.Dialogs
{
    public static class IDialogServiceExtensions
    {
        public static void ShowNotificationDialog(this IDialogService dialogService, string message, Action<IDialogResult> callBack)
        {
            dialogService.ShowDialog(DialogNames.NotificationDialog, new DialogParameters($"message={message}"), callBack);
        }

        public static void ShowYesNoDialog(this IDialogService dialogService, string message, Action<IDialogResult> callBack)
        {
            dialogService.ShowDialog(DialogNames.YesNoDialog, new DialogParameters($"message={message}"), callBack);
        }
    }
}
