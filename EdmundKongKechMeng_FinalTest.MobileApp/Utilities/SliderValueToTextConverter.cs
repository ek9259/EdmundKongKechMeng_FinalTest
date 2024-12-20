using System.Globalization;

namespace EdmundKongKechMeng_FinalTest.MobileApp.Utilities;

public class SliderValueToTextConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is double sliderValue)
        {
            if (sliderValue < 40)
            {
                return "Failed";
            }
            else if (sliderValue < 80)
            {
                return "Passed";
            }
            else
            {
                return "Excellent";
            }
        }

        return string.Empty;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class SliderValueToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is double sliderValue)
        {
            if (sliderValue < 40)
            {
                return Colors.Red;
            }
            else if (sliderValue < 80)
            {
                return Colors.Black;
            }
            else
            {
                return Colors.Green;
            }
        }

        return Colors.Black;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}