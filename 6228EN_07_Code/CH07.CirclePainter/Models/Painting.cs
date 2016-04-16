using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CH07.CirclePainter.Models {
	class Painting {
		ObservableCollection<Circle> _circles;

		public ObservableCollection<Circle> Circles {
			get {
				if(_circles == null)
					_circles = new ObservableCollection<Circle>();
				return _circles; 
			}
		}

	}
}
