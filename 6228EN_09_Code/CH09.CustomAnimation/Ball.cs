using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;

namespace CH09.CustomAnimation {
	class Ball : INotifyPropertyChanged {
		Point _position, _velocity;

		public Environment Environment { get; private set; }

		public Ball(Environment env) {
			Environment = env;		
		}

		public double X {
			get { return _position.X; }
			set {
				_position.X = value;
				OnPropertyChanged("X");
			}
		}

		public double Y {
			get { return _position.Y; }
			set {
				_position.Y = value;
				OnPropertyChanged("Y");
			}
		}

		public double Width { get; set; }

		public double Height { get; set; }

		public Point Velocity {
			get { return _velocity; }
			set { 
				_velocity = value;
				OnPropertyChanged("Velocity");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged(string propName) {
			var pc = PropertyChanged;
			if (pc != null)
				pc(this, new PropertyChangedEventArgs(propName));
		}

		public void Move(Rect bounds) {
			_velocity.Y += Environment.Gravity;
			X += Velocity.X;
			Y += Velocity.Y;
			bool xhit = false, yhit = false;
			if(X < bounds.Left) {
				X = bounds.Left;
				xhit = true;
			}
			else if(X > bounds.Right - Width) {
				X = bounds.Right - Width;
				xhit = true;
			}
			if(Y < bounds.Top) {
				Y = bounds.Top;
				yhit = true;
			}
			else if(Y > bounds.Bottom - Height) {
				Y = bounds.Bottom - Height;
				yhit = true;
			}

			if(xhit) {
				_velocity.X = -_velocity.X;
				_velocity.X *= Environment.Traction;
			}
			if(yhit) {
				_velocity.Y = -_velocity.Y;
				_velocity.Y *= Environment.Traction;
			}
		}

	}
}
