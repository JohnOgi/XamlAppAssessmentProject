using System.Globalization;

namespace XamlAppAssessmentProject.ValueConverters
{
    internal class RunningTimeConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var seconds = System.Convert.ToDouble(value);
            var ts = TimeSpan.FromSeconds(seconds);
            return ts.ToString();
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
