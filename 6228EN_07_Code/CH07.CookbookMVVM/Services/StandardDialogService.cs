using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CH07.CookbookMVVM.Services {
	public sealed class StandardDialogService<TWindow> : IDialogService where TWindow : Window, new() {
		public bool? ShowDialog() {
			var win = new TWindow();
			win.DataContext = ViewModel;
			return win.ShowDialog();
		}

		public object ViewModel { get; set; }
	}
}
