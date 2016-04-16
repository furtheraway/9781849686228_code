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

namespace CH03.SharedGridSizeDemo {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			DataContext = new List<Person> {
				new Person { Name = "Bart", Age = 10 },
				new Person { Name = "Marge", Age = 35 },
				new Person { Name = "Homer", Age = 40 },
				new Person { Name = "Lisa", Age = 12 },
				new Person { Name = "Maggie", Age = 2 },
			};


		}
	}
}
