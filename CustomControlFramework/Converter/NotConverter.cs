using System;
using System.Globalization;

namespace CustomControlFramework.Converter;

public class NotConverter : IValueConverter, IMarkupExtension
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value is bool result)
        {
            return !result;
        }
        return false;;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public object ProvideValue(IServiceProvider serviceProvider) => this;
}
