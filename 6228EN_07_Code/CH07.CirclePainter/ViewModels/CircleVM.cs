using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;
using CH07.CirclePainter.Commands;
using CH07.CirclePainter.Models;
using CH07.CookbookMVVM;

namespace CH07.CirclePainter.ViewModels {
	class CircleVM : ViewModelBase<Circle, MainVM> {
		const double radius = 15;

		public CircleVM(MainVM mainVM, Circle circle)
			: base(circle, mainVM) {
			circle.PropertyChanged += (s, e) => {
				switch(e.PropertyName) {
					case "X":
						OnPropertyChanged("X");
						break;
					case "Y":
						OnPropertyChanged("Y");
						break;
				}
			};
		}

		public double X {
			get { return Model.X - radius; }
			set {
				Model.X = value + radius;
			}
		}

		public double Y {
			get { return Model.Y - radius; }
			set {
				Model.Y = value + radius;
			}
		}

		public Brush Color {
			get { return new SolidColorBrush(System.Windows.Media.Color.FromRgb(Model.Color.Red, Model.Color.Green, Model.Color.Blue)); }
		}

		public ICommand RemoveCircleCommand {
			get {
				return Parent.RemoveCircleCommand;
			}
		}

		public ICommand MoveCircleCommand {
			get { return new ReversibleCommand(Parent.UndoManager, new MoveCircleCommand(Parent)); }
		}
	}
}
