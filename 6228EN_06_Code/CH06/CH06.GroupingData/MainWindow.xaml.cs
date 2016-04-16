using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace CH06.GroupingData {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			var processes = Process.GetProcesses().Where(CanAccess);
			var view = CollectionViewSource.GetDefaultView(processes);
			view.GroupDescriptions.Add(new PropertyGroupDescription("PriorityClass"));
			DataContext = processes;
		}

		public static bool CanAccess(Process process) {
			try {
				var h = process.Handle;
				return true;
			}
			catch {
				return false;
			}
		}
	}
}
