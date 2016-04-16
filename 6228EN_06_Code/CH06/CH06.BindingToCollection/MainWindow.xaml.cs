﻿using System;
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
using System.Collections.ObjectModel;

namespace CH06.BindingToCollection {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		ObservableCollection<Person> _people;

		public MainWindow() {
			InitializeComponent();

			_people = new ObservableCollection<Person> {
				new Person { Name = "Bart", Age = 10 },
				new Person { Name = "Homer", Age = 45 },
				new Person { Name = "Marge", Age = 35 },
				new Person { Name = "Lisa", Age = 12 },
				new Person { Name = "Maggie", Age = 1 }
			};

			_list.ItemsSource = _people;
			DataContext = _people;
		}

		private void OnAdd(object sender, RoutedEventArgs e) {
			_people.Add(new Person { Name = "Moe", Age = 40 });
		}
	}
}
