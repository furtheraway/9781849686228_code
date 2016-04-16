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
using CH07.CirclePainter.Commands;
using CH07.CirclePainter.ViewModels;
using System.Diagnostics;

namespace CH07.CirclePainter {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			DataContext = new MainVM();
			InitializeComponent();
		}

		private void OnMouseUp(object sender, MouseButtonEventArgs e) {
			if(_moving) {
				_moving = false;
				var canvas = sender as IInputElement;
				canvas.ReleaseMouseCapture();
				var pt = e.GetPosition(canvas);
				var args = new MoveCircleCommandArgs { 
					OldPosition = new Point(_start.X - _offset.X, _start.Y - _offset.Y),
					NewPosition = new Point(pt.X - _offset.X, pt.Y - _offset.Y),
					Circle = _circle.Model
				};
				_circle.MoveCircleCommand.Execute(args);
			}
			else {
				var pt = e.GetPosition(sender as IInputElement);
				var vm = (MainVM) DataContext;
				vm.AddCircleCommand.Execute(vm.CircleFromPoint(pt));
			}
		}

		bool _moving;
		CircleVM _circle;
		Point _offset, _start;
		private void OnMouseDown(object sender, MouseButtonEventArgs e) {
			var ellipse = e.Source as Ellipse;
			if(ellipse != null) {
				_moving = true;
				var canvas = sender as IInputElement;
				_offset = e.GetPosition(ellipse);
				_start = e.GetPosition(canvas);
				_circle = (CircleVM)ellipse.DataContext;
				canvas.CaptureMouse();
			}
		}

		private void OnMouseMove(object sender, MouseEventArgs e) {
			if(_moving) {
				var pt = e.GetPosition(sender as IInputElement);
				_circle.X = pt.X - _offset.X;
				_circle.Y = pt.Y - _offset.Y;
			}
		}
	}
}
