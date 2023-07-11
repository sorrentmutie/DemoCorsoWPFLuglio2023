using System;
using System.Globalization;
using System.Windows.Data;

namespace DemoCorsoWPF.Converters;

public class YesNoToBooleanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var input = value.ToString();

        if(input != null)
        {
            switch (input!.ToLower())
            {
                case "yes":
                case "si":
                case "oui":
                    return true;
                case "no":
                case "non":
                default:
                    return false;
            }
        }
        return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value is bool input)
        {
            return input ? "Yes" : "No";
        }
        return "No";
    }
}
