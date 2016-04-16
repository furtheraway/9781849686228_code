using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace CH06.SortingAndFiltering2 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		CollectionViewSource _cvs;
		public MainWindow() {
			InitializeComponent();

			_cvs = new CollectionViewSource();
			_cvs.Source = Process.GetProcesses();
			DataContext = _cvs;
		}

		private void OnSort(object sender, RoutedEventArgs e) {
			var view = _cvs.View;
			view.SortDescriptions.Clear();
			if(_sortField.SelectedValue != null)
				view.SortDescriptions.Add(new SortDescription((string)_sortField.SelectedValue,
					_ascending.IsChecked == true ? ListSortDirection.Ascending : ListSortDirection.Descending));
		}

		private void OnFilter(object sender, RoutedEventArgs e) {
			var view = _cvs.View;
			if(string.IsNullOrWhiteSpace(_filterText.Text))
				view.Filter = null;
			else
				view.Filter = obj => ((Process)obj).ProcessName.IndexOf(_filterText.Text, StringComparison.InvariantCultureIgnoreCase) > -1;
		}
	}
}
