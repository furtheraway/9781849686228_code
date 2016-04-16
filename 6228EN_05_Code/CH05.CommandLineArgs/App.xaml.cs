﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace CH05.CommandLineArgs {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {
		protected override void OnStartup(StartupEventArgs e) {
			string text = "Hello, default!";
			if(e.Args.Length > 0)
				text = e.Args[0];

			var win = new MainWindow(text);
			win.Show();
		}
	}
}
