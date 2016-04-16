﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace CH10.CustomControls {
	class ColorToBrushConverter : IValueConverter {
		SolidColorBrush _red = new SolidColorBrush(), _green = new SolidColorBrush(), _blue = new SolidColorBrush(),
			_alpha = new SolidColorBrush();

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
			var color = (Color)value;
			switch((string)parameter) {
				case "r":
					_red.Color = Color.FromRgb(color.R, 0, 0);
					return _red;
				case "g":
					_green.Color = Color.FromRgb(0, color.G, 0);
					return _green;
				case "b":
					_blue.Color = Color.FromRgb(0, 0, color.B);
					return _blue;
				case "a":
					_alpha.Color = Color.FromArgb(color.A, 128, 128, 128);
					return _alpha;
			}
			return Binding.DoNothing;
		}
/*
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
			var color = (Color)value;
			var brush = new SolidColorBrush();
			switch((string)parameter) {
				case "r":
					brush.Color = Color.FromRgb(color.R, 0, 0);
					break;
				case "g":
					brush.Color = Color.FromRgb(0, color.G, 0);
					break;
				case "b":
					brush.Color = Color.FromRgb(0, 0, color.B);
					break;
				case "a":
					brush.Color = Color.FromArgb(color.A, 128, 128, 128);
					break;
			}
			return brush;
		}
*/
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
			throw new NotImplementedException();
		}
	}
}
