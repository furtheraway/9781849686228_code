using System.Collections.Generic;
using System.Windows;

namespace CH08.DataTriggerDemo {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			DataContext = new List<Book> {
				new Book { BookName = "Windows Internals", AuthorName = "Mark Russinovich", IsFree = false },
				new Book { BookName = "AJAX Introduction", AuthorName = "Bhanwar Gupta", IsFree = true },
				new Book { BookName = "Essential COM", AuthorName = "Don Box", IsFree = false },
				new Book { BookName = "Blueprint for a Successful Presentation", AuthorName = "Biswajit Tripathy", IsFree = true }
			};
		}
	}
}
