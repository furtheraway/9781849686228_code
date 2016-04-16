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
using System.Windows.Threading;

namespace CH04.ImageSources {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		WriteableBitmap _bmp;
		DispatcherTimer _timer;
		Random _rnd = new Random();
		int[] _pixel = { 255 };

		public MainWindow() {
			InitializeComponent();

			_bmp = new WriteableBitmap(100, 100, 0, 0, PixelFormats.Gray8, null);
			_image.Source = _bmp;
			_timer = new DispatcherTimer();
			_timer.Interval = TimeSpan.FromMilliseconds(20);
			_timer.Tick += delegate {
				int x = _rnd.Next(_bmp.PixelWidth), y = _rnd.Next(_bmp.PixelHeight);
				_bmp.WritePixels(new Int32Rect(x, y, 1, 1), _pixel, _bmp.BackBufferStride, 0);
			};
			_timer.Start();
		}
	}
}
