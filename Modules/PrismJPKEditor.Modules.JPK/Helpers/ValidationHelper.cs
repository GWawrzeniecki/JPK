using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace PrismJPKEditor.Modules.JPK.Helpers
{
    public static class ValidationHelper
    {
        public static void ReMarkInvalid(DataGridTextColumn obj)
        {
            if (Validation.GetHasError(obj))
            {
                //List<ValidationError> errors = new List<ValidationError>(Validation.GetErrors(obj));
                //foreach (ValidationError error in errors)
                //{
                //    Validation.ClearInvalid((BindingExpressionBase)error.BindingInError);
                //    //Validation.MarkInvalid((BindingExpressionBase)error.BindingInError, error);



                //}
                
                //Validation.MarkInvalid(obj.get);
            }

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                //ReMarkInvalid(VisualTreeHelper.GetChild(obj, i));
            }
        }
    }
}
