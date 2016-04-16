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
using System.Windows.Shapes;

namespace CH05.DefaultButtons {
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window {
		public LoginWindow() {
			InitializeComponent();

		}

		public string Username { get; private set; }
		public string Password { get; private set; }

		private void OnLogin(object sender, RoutedEventArgs e) {
			Username = _username.Text;
			Password = _password.Password;
			DialogResult = true;
			Close();
		}
	}
}
