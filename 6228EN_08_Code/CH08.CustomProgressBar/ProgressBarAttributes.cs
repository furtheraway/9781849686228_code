using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CH08.CustomProgressBar {
	public static class ProgressBarAttributes {
		public static bool GetShowText(DependencyObject obj) {
			return (bool)obj.GetValue(ShowTextProperty);
		}

		public static void SetShowText(DependencyObject obj, bool value) {
			obj.SetValue(ShowTextProperty, value);
		}

		public static readonly DependencyProperty ShowTextProperty =
			 DependencyProperty.RegisterAttached("ShowText", typeof(bool), typeof(ProgressBarAttributes), new UIPropertyMetadata(true));
	}
}
