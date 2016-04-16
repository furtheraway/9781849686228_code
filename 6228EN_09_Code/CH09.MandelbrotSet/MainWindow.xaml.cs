﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace CH09.MandelbrotSet {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		WriteableBitmap _bmp;

		public MainWindow() {
			InitializeComponent();

			_bmp = new WriteableBitmap(600, 600, 0, 0, PixelFormats.Gray8, null);
			_image.Source = _bmp;
			CalcMandelbrotSet();
		}

		void CalcMandelbrotSet() {
			var from = new Complex(-1.5, -1);
			var to = new Complex(1, 1);
			double deltax = (to.Real - from.Real) / _bmp.Width;
			double deltay = (to.Imaginary - from.Imaginary) / _bmp.Height;

			byte[] pixels = new byte[_bmp.PixelWidth];

			for(int y = 0; y < _bmp.PixelHeight; y++) {
				for (int x = 0; x < _bmp.PixelWidth; x++)
					pixels[x] = (byte)MandelbrotColor(from + new Complex(x * deltax, y * deltay));
				_bmp.WritePixels(new Int32Rect(0, y, _bmp.PixelWidth, 1), pixels, _bmp.BackBufferStride, 0);
			}
		}

		int MandelbrotColor(Complex c) {
			int color = 256;

			Complex z = Complex.Zero;
			while(z.Real + z.Imaginary < 4 && color > 0) {
				z = z * z + c;
				color--;
			}
			return color;
		}

	}
}
