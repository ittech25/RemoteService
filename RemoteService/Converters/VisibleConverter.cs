﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace RemoteService.Converters
{
    class VisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool val = (bool)value;

            if (val)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class InverseVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool val = (bool)value;

            if (val)
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Visible;
            }


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
