﻿using FlightTicketSell.Models;
using System;
using System.Globalization;
using System.Linq;

namespace FlightTicketSell.ValueConverters
{
    public class AppViewToBooleanConverter : BaseValueConverter<AppViewToBooleanConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((AppView)parameter)
            {
                case AppView.Search:
                    return new[] { AppView.Search }.Any(x => x == (AppView)value);
                case AppView.Book:
                    return new[] { AppView.Book, AppView.BookDetail }.Any(x => x == (AppView)value);
                case AppView.Sell:
                    return new[] { AppView.Sell}.Any(x => x == (AppView)value);
                case AppView.Schedule:
                    return new[] { AppView.Schedule}.Any(x => x == (AppView)value);
                case AppView.Report:
                    return new[] { AppView.Report, AppView.ReportPrint}.Any(x => x == (AppView)value);
                case AppView.Setting:
                    return new[] { AppView.Setting}.Any(x => x == (AppView)value);
                default:
                    return null;
            }
            
            return (AppView)value == (AppView)parameter;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
