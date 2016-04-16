﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace CH05.OwnerWindows {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {
		protected override void OnStartup(StartupEventArgs e) {
			var mainWindow = new MainWindow();
			var toolWindow = new ToolsWindow();
			mainWindow.Show();
			toolWindow.Owner = mainWindow;
			toolWindow.Show();
		}
	}
}
