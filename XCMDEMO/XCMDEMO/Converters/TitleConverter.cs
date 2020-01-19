using System;
using System.Globalization;
using Xamarin.Forms;
using XCMDEMO.ViewModels;

namespace XCMDEMO.Converters
{
    public class TitleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = (IChildViewModel)value;
            return result.Title;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}