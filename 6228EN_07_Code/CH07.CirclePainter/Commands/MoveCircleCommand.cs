using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using CH07.CirclePainter.Models;
using CH07.CirclePainter.ViewModels;
using CH07.CookbookMVVM;

namespace CH07.CirclePainter.Commands {
	class MoveCircleCommandArgs {
		public Point OldPosition { get; set; }
		public Point NewPosition { get; set; }
		public Circle Circle { get; set; }
	}

	class MoveCircleCommand : CommandBase{
		MainVM _vm;
		MoveCircleCommandArgs _args;

		public MoveCircleCommand(MainVM vm) {
			_vm = vm;
		}

		public override void Execute(object parameter) {
			if(_args == null) _args = (MoveCircleCommandArgs)parameter;
			_vm.SetCirclePosition(_args.Circle, _args.NewPosition);
			var temp = _args.NewPosition;
			_args.NewPosition = _args.OldPosition;
			_args.OldPosition = temp;
		}

		public override void Undo() {
			Execute(null);
		}
	}
}
