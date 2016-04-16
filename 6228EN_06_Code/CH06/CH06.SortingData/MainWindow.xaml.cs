using System.Linq;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.ComponentModel;
using System;

namespace CH06.SortingAndFiltering {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			DataContext = Process.GetProcesses();
		}

		private void OnSort(object sender, RoutedEventArgs e) {
			var view = CollectionViewSource.GetDefaultView(DataContext);
			view.SortDescriptions.Clear();
			if(_sortField.SelectedValue != null)
				view.SortDescriptions.Add(new SortDescription((string)_sortField.SelectedValue, 
					_ascending.IsChecked == true ? ListSortDirection.Ascending : ListSortDirection.Descending));
		}

		private void OnFilter(object sender, RoutedEventArgs e) {
			var view = CollectionViewSource.GetDefaultView(DataContext);
			if(string.IsNullOrWhiteSpace(_filterText.Text))
				view.Filter = null;
			else
				view.Filter = obj => ((Process)obj).ProcessName.IndexOf(_filterText.Text, StringComparison.InvariantCultureIgnoreCase) > -1;
		}
	}
}
