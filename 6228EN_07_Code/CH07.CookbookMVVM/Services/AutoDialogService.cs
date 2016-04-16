using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH07.CookbookMVVM.Services {
	public sealed class AutoDialogService : IDialogService {
		public bool? DialogResult { get; set; }

		public AutoDialogService() {
			DialogResult = true;
		}

		public bool? ShowDialog() {
			return DialogResult;
		}

		public object ViewModel { get; set; }
	}
}
