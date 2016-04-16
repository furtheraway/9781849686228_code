using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CH06.ElementToElementCodeBindings {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			var binding = new Binding("Value");
//			binding.Source = _slider;
			binding.ElementName = "_slider";
			_text.SetBinding(TextBlock.FontSizeProperty, binding);

		}
	}
}
