using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Labo2Minutes_UI
{
    [ValueConversion(typeof(string), typeof(int))]
    public class ConvertisseurIntDouble : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int num;
            string chaine = value as string;
            if (int.TryParse(chaine, out num) && !chaine.EndsWith("."))
            {
                return num;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
