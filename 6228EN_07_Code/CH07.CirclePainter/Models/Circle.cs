using CH07.CookbookMVVM;

namespace CH07.CirclePainter.Models {
	class CircleColor {
		public byte Red { get; set; }
		public byte Green { get; set; }
		public byte Blue { get; set; }
	}

	class Circle : ObservableObject {
		CircleColor _color;
		public CircleColor Color {
			get { return _color; }
			set { SetProperty(ref _color, value, () => Color); }
		}

		public double Y {
			get { return _y; }
			set { SetProperty(ref _y, value, () => Y); }
		}

		public double X {
			get { return _x; }
			set { SetProperty(ref _x, value, () => X); }
		}

		double _x;
		double _y;
		double _radius;
	}
}
