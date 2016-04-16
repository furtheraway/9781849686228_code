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

namespace CH05.DefaultButtons {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			do {
				var loginWindow = new LoginWindow();
				if(loginWindow.ShowDialog() == true) {
					// attempt login...
					if(loginWindow.Username == "u1" && loginWindow.Password == "wpf123")
						break;
					MessageBox.Show("Login failed!");
				}
				else {
					// cancelled
					MessageBox.Show("You must login!");
				}
			} while(true);

		}
	}
}
