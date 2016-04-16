using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using CH07.CirclePainter.Models;
using CH07.CirclePainter.ViewModels;
using CH07.CookbookMVVM;

namespace CH07.CirclePainter.Commands {
	class AddCircleCommand : CommandBase {
		readonly Painting _painting;

		public AddCircleCommand(Painting painting) {
			_painting = painting;
		}

		protected Circle Circle { get; set; }

		public override void Execute(object parameter) {
			if(Circle == null) Circle = (Circle)parameter;
			_painting.Circles.Add(Circle);
		}

		public override void Undo() {
			Debug.Assert(Circle != null);
			_painting.Circles.Remove(Circle);
		}
	}

	class RemoveCircleCommand : AddCircleCommand {
		public RemoveCircleCommand(Painting painting) : base(painting) {
		}

		public override void Execute(object parameter) {
			if(Circle == null) Circle = (Circle)parameter;
			base.Undo();
		}

		public override void Undo() {
			base.Execute(null);
		}
	}
}
