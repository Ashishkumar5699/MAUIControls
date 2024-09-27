using System;
using System.Globalization;

namespace CustomControlFramework.Converter
{
	public class BoolToColorConverter : IValueConverter, IMarkupExtension
    {
		public BoolToColorConverter()
		{
		}

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = false;

            if(value is bool _condition)
            {
                result = _condition;
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider) => this;
    }
}

