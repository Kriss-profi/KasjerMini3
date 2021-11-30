using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace KasjerMini3
{
    public class DiferencColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal d = (decimal)value;
            return d < 0 ? Brushes.Red : Brushes.Black;

            //return new SolidColorBrush(c);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
