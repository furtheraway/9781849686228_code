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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CH09.CustomAnimation {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		Ball _ball;
		bool _grabbing;
		private Point _mousePos, _lastDelta;
		const double MaxSpeed = 20;

		public MainWindow() {
			InitializeComponent();

			var env = new Environment { Gravity = .8 };
			_ball = new Ball(env) { Width = 40, Height = 40, Velocity = new Point(3, 1) };
			DataContext = _ball;

			CompositionTarget.Rendering += CompositionTarget_Rendering;
		}

		
		//int _count;
		//DateTime _last = DateTime.Now;
		void CompositionTarget_Rendering(object sender, EventArgs e) {
			//_count++;
			//if(DateTime.Now - _last >= TimeSpan.FromSeconds(1)) {
			//   _last = DateTime.Now;
			//   Title = _count.ToString() + " FPS";
			//   _count = 0;
			//}
			if(!_grabbing)
				_ball.Move(new Rect(new Point(0, 0), _canvas.RenderSize));
		}

		private void OnGrabObject(object sender, MouseButtonEventArgs e) {
			_grabbing = true;
			_mousePos = e.GetPosition(_canvas);
			e.Handled = true;
			var element = sender as FrameworkElement;
			element.CaptureMouse();
		}

		private void OnMouseMove(object sender, MouseEventArgs e) {
			if(_grabbing) {
				Point pt = e.GetPosition(_canvas);
				_lastDelta = new Point(pt.X - _mousePos.X, pt.Y - _mousePos.Y);
				_ball.X += _lastDelta.X; _ball.Y += _lastDelta.Y;
				_mousePos = pt;
			}
		}

		private void OnReleaseObject(object sender, MouseButtonEventArgs e) {
			if(_grabbing) {
				_grabbing = false;
				e.Handled = true;
				((FrameworkElement)sender).ReleaseMouseCapture();
				if(Math.Abs(_lastDelta.X) > MaxSpeed)
					_lastDelta.X = MaxSpeed * Math.Sign(_lastDelta.X);
				if(Math.Abs(_lastDelta.Y) > MaxSpeed)
					_lastDelta.Y = MaxSpeed * Math.Sign(_lastDelta.Y);
				_ball.Velocity = _lastDelta;
			}
		}

	}
}
