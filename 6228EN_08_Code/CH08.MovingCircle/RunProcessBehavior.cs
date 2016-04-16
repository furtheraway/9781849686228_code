using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Diagnostics;

namespace CH08.MovingCircle {
	class RunProcessBehavior : Behavior<FrameworkElement> {
		public string Program { get; set; }
		public string Arguments { get; set; }

		protected override void OnAttached() {
			AssociatedObject.MouseLeftButtonUp += OnMouseClick;
		}

		void OnMouseClick(object sender, RoutedEventArgs e) {
			Process.Start(Program, Arguments);
		}

		protected override void OnDetaching() {
			AssociatedObject.MouseLeftButtonUp -= OnMouseClick;
		}
	}
}
