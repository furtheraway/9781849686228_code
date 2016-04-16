using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.IO;
using System.Diagnostics;

namespace CH05.UnhandledExceptions {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {
		public App() {
			DispatcherUnhandledException += OnUnhandledException;
		}

		void OnUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) {
			Trace.WriteLine(string.Format("{0}: Error: {1}", DateTime.Now, e.Exception));
			MessageBox.Show("Error encountered! Please contact support." +  
				Environment.NewLine + e.Exception.Message);
			Shutdown(1);
			e.Handled = true;
		}
	}
}
