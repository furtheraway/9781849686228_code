using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace CH09.SimpleAnimation {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void OnRotate(object sender, RoutedEventArgs e) {
			var animation = new DoubleAnimation(360, TimeSpan.FromSeconds(2), FillBehavior.Stop);
			Storyboard.SetTarget(animation, rot1);
			rot1.BeginAnimation(RotateTransform.AngleProperty, animation);
		}
	}
}
