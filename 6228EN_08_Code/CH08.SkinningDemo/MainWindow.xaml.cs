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
using System.Windows.Markup;

namespace CH08.SkinningDemo {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void OnSkinDefault(object sender, RoutedEventArgs e) {
			ChangeSkin("/Skins/DefaultSkin.xaml");
		}

		void ChangeSkin(string skinRelativeUri) {
			var si = Application.GetContentStream(new Uri(skinRelativeUri, UriKind.Relative));
			var rd = (ResourceDictionary)XamlReader.Load(si.Stream);
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(rd);
		}

		private void OnSkinRed(object sender, RoutedEventArgs e) {
			ChangeSkin("/Skins/RedSkin.xaml");
		}

		private void OnBlueSkin(object sender, RoutedEventArgs e) {
			ChangeSkin("/Skins/BlueSkin.xaml");
		}
	}
}
