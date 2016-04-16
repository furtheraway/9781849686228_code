using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CH07.CirclePainter.Models;
using CH07.CirclePainter.ViewModels;
using CH07.CookbookMVVM;

namespace CH07.CirclePainter.Commands {
	class DeleteAllCommand : CommandBase {
		Circle[] _circles;
		Painting _painting;

		public DeleteAllCommand(Painting painting) {
			_painting = painting;
		}
		public override void Execute(object parameter) {
			_circles = new Circle[_painting.Circles.Count];
			_painting.Circles.CopyTo(_circles, 0);
			_painting.Circles.Clear();
		}

		public override void Undo() {
			foreach(var c in _circles)
				_painting.Circles.Add(c);
		}
	}
}
