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

namespace CH05.Dialogs {
	/// <summary>
	/// Interaction logic for DetailsDialog.xaml
	/// </summary>
	public partial class DetailsDialog : Window {
		public DetailsDialog() {
			InitializeComponent();
		}

		private void OnOK(object sender, RoutedEventArgs e) {
			FullName = _name.Text;
			City = _city.Text;
			DialogResult = true;
			Close();
		}

		public string FullName { get; private set; }
		public string City { get; private set; }

		private void OnCancel(object sender, RoutedEventArgs e) {
			DialogResult = false;
			Close();
		}
	}
}
