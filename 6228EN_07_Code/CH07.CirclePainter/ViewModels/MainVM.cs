using System.Linq;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using CH07.CirclePainter.Commands;
using CH07.CookbookMVVM;
using CH07.CirclePainter.Models;

namespace CH07.CirclePainter.ViewModels {
	class MainVM : ViewModelBase<Painting> {
		public UndoManager UndoManager { get; private set; }

		public MainVM()
			: base(new Painting()) {
			Model.Circles.CollectionChanged += (s, e) => {
				OnPropertyChanged("Circles");
			};
			Name = "dummy";
			UndoManager = new UndoManager();
		}

		public string Name { get; set; }

		static readonly SolidColorBrush[] _brushes = {
			Brushes.Black, Brushes.Green, Brushes.Red, Brushes.Blue, Brushes.Yellow,
			Brushes.Brown, Brushes.Orange
		};

		public IEnumerable<Brush> Colors {
			get { return _brushes; }
		}

		SolidColorBrush _selectedColor = Brushes.Black;
		public SolidColorBrush SelectedColor {
			get { return _selectedColor; }
			set { SetProperty(ref _selectedColor, value, () => SelectedColor); }
		}

		ICommand _undoCommand;
		public ICommand UndoCommand {
			get {
				return _undoCommand ?? (_undoCommand = new RelayCommand(() => UndoManager.Undo(), () => UndoManager.CanUndo));
			}
		}

		ICommand _redoCommand;
		public ICommand RedoCommand {
			get {
				return _redoCommand ?? (_redoCommand = new RelayCommand(() => UndoManager.Redo(), () => UndoManager.CanRedo));
			}
		}

		public ICommand AddCircleCommand {
			get {
				return new ReversibleCommand(UndoManager, new AddCircleCommand(Model));
			}
		}

		public ICommand RemoveCircleCommand {
			get {
				return new ReversibleCommand(UndoManager, new RemoveCircleCommand(Model));
			}
		}

		public ICommand DeleteAllCommand {
			get { return new ReversibleCommand(UndoManager, new DeleteAllCommand(Model)); }
		}

		public IEnumerable<CircleVM> Circles {
			get { return Model.Circles.Select(c => new CircleVM(this, c)); }
		}

		public Circle CircleFromPoint(Point pt) {
			var color = SelectedColor.Color;
			return new Circle { X = pt.X, Y = pt.Y, Color = new CircleColor { Red = color.R, Green = color.G, Blue = color.B } };
		}

		public void SetCirclePosition(Circle circle, Point point) {
			var vm = Circles.Single(c => c.Model == circle);
			vm.X = point.X;
			vm.Y = point.Y;
		}
	}
}
