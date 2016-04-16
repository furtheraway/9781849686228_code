﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows;
using System.Globalization;

namespace CH10.CustomControls {
	class ColorToDoubleConverter : IValueConverter {
		Color _lastColor;

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			var color = (Color)value;
			_lastColor = color;
			switch((string)parameter) {
				case "r": return color.R;
				case "g": return color.G;
				case "b": return color.B;
				case "a": return color.A;
			}
			return Binding.DoNothing;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			Color color = _lastColor;
			var intensity = (byte)(double)value;
			switch((string)parameter) {
				case "r":
					color.R = intensity;
					break;
				case "g":
					color.G = intensity;
					break;
				case "b":
					color.B = intensity;
					break;
				case "a":
					color.A = intensity;
					break;
			}
			_lastColor = color;
			return color;
		}
	}
}
