using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppGallery.XamarinForms.ClassesUteis.Conversores
{
    public class OpcionalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((string)value)
                .Replace("1", "Opcional 1")
                .Replace("2", "Opcional 2")
                .Replace("3", "Opcional 3")
                .Replace("4", "Opcional 4");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
