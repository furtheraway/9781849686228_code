using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Interop;

namespace CH05.SingleInstApp {
	class ActivationService : IActivateWindow {
		public void Activate(string[] args) {
			var helper = new WindowInteropHelper(Application.Current.MainWindow);
			if(App.IsIconic(helper.Handle))
				App.OpenIcon(helper.Handle);
			App.SetForegroundWindow(helper.Handle);
			// use args...
		}
	}
}
