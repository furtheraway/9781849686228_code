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

namespace CH08.CustomItemsPanel {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void OnChangeView(object sender, RoutedEventArgs e) {
			var tag = ((FrameworkElement)e.Source).Tag.ToString();
			_list.ItemsPanel = (ItemsPanelTemplate)FindResource(tag);
			ScrollViewer.SetHorizontalScrollBarVisibility(_list, tag == "3" ? ScrollBarVisibility.Disabled : ScrollBarVisibility.Auto);
		}
	}
}
