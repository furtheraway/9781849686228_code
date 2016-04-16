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
using Microsoft.Win32;

namespace CH05.CommonDialogs {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		void OnOpenImage(object sender, RoutedEventArgs e) {
			var dlg = new OpenFileDialog {
				Filter = "Image files|*.png;*.jpg;*.gif;*.bmp",
				Title = "Select image to open",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
			};

			if(dlg.ShowDialog() == true) {
				try {
					var bmp = new BitmapImage(new Uri(dlg.FileName));
					_img.Source = bmp;
				}
				catch(Exception ex) {
					MessageBox.Show(ex.Message, "Open Image");
				}
			}
		}
	}
}
