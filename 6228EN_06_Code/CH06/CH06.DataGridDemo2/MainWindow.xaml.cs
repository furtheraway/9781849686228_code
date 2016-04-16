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
using System.Diagnostics;

namespace CH06.DataGridDemo2 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			DataContext = new List<PersonInfo> {
				new PersonInfo { FirstName = "Bart", LastName = "Simpson", Email = "bart@runaway.com", IsEmployed = false, Gender = Gender.Male, Avatar = new Uri("Images/sun.png", UriKind.Relative) },
				new PersonInfo { FirstName = "Homer", LastName = "Simpson", Email = "homer@springfield.com", IsEmployed = true, Gender = Gender.Male, Avatar = new Uri("Images/worker.png", UriKind.Relative) },
				new PersonInfo { FirstName = "Marge", LastName = "Simpson", Email = "marge@desparatehousewives.com", IsEmployed = false, Gender = Gender.Female, Avatar = new Uri("Images/violin.png", UriKind.Relative) },
				new PersonInfo { FirstName = "Lisa", LastName = "Simpson", Email = "lisa@musiclovers.com", IsEmployed = false, Gender = Gender.Female, Avatar = new Uri("Images/woman.png", UriKind.Relative) },
				new PersonInfo { FirstName = "Maggie", LastName = "Simpson", IsEmployed = false, Gender = Gender.Female, Avatar = new Uri("Images/wine.png", UriKind.Relative) }
			};
		}

		private void OnSendEmail(object sender, RoutedEventArgs e) {
			var hyperlink = (Hyperlink)sender;
			if(hyperlink.NavigateUri != null)
				Process.Start("mailto: " + hyperlink.NavigateUri);
		}
	}
}
