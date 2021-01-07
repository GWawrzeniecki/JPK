using System;
using System.Globalization;
using System.Windows.Data;

namespace PrismJPKEditor.Modules.JPK.Converters
{
    public class StringToNullableIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (int.TryParse(value?.ToString(), out int result))
            {
                int? val = result;
                return val;


            }
            else
            {
                int? val = null;
                return val;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (int.TryParse(value?.ToString(), out int result))
            {
                return result.ToString();
            }
            else
            {
                return null;
            }
        }
    }

}
