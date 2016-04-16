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

namespace CH10.UserControls {
	/// <summary>
	/// Interaction logic for ColorPicker.xaml
	/// </summary>
	public partial class ColorPicker : UserControl {
		public ColorPicker() {
			InitializeComponent();

		}

		static ColorPicker() {
			CommandManager.RegisterClassCommandBinding(typeof(ColorPicker),
				new CommandBinding(MediaCommands.ChannelUp, ChannelUpExecute, ChannelUpCanExecute));
			CommandManager.RegisterClassCommandBinding(typeof(ColorPicker),
				new CommandBinding(MediaCommands.ChannelDown, ChannelDownExecute, ChannelDownCanExecute));
		}

		static void ChannelUpExecute(object sender, ExecutedRoutedEventArgs e) {
			var cp = (ColorPicker)sender;
			var color = cp.SelectedColor;
			if(color.R < 255) color.R++;
			if(color.G < 255) color.G++;
			if(color.B < 255) color.B++;
			cp.SelectedColor = color;
		}

		static void ChannelUpCanExecute(object sender, CanExecuteRoutedEventArgs e) {
			var color = ((ColorPicker)sender).SelectedColor;
			e.CanExecute = color.R < 255 || color.G < 255 || color.B < 255;
		}

		static void ChannelDownExecute(object sender, ExecutedRoutedEventArgs e) {
			var cp = (ColorPicker)sender;
			var color = cp.SelectedColor;
			if(color.R > 0) color.R--;
			if(color.G > 0) color.G--;
			if(color.B > 0) color.B--;
			cp.SelectedColor = color;
		}

		static void ChannelDownCanExecute(object sender, CanExecuteRoutedEventArgs e) {
			var color = ((ColorPicker)sender).SelectedColor;
			e.CanExecute = color.R > 0 || color.G > 0 || color.B > 0;
		}


		public static readonly DependencyProperty SelectedColorProperty =
			DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorPicker), new UIPropertyMetadata(Colors.Black, OnSelectedColorChanged));

		public Color SelectedColor {
			get { return (Color)GetValue(SelectedColorProperty); }
			set { SetValue(SelectedColorProperty, value); }
		}


		public bool ShowAlphaChannel {
			get { return (bool)GetValue(ShowAlphaChannelProperty); }
			set { SetValue(ShowAlphaChannelProperty, value); }
		}

		public static readonly DependencyProperty ShowAlphaChannelProperty =
			 DependencyProperty.Register("ShowAlphaChannel", typeof(bool), typeof(ColorPicker), new UIPropertyMetadata(true));


		public static RoutedEvent SelectedColorChangedEvent = EventManager.RegisterRoutedEvent("SelectedColorChanged", RoutingStrategy.Bubble,
			typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ColorPicker));

		public static RoutedEvent PreviewSelectedColorChangedEvent = EventManager.RegisterRoutedEvent("PreviewSelectedColorChanged", RoutingStrategy.Tunnel,
			typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ColorPicker));

		public event RoutedPropertyChangedEventHandler<Color> SelectedColorChanged {
			add { AddHandler(SelectedColorChangedEvent, value); }
			remove { RemoveHandler(SelectedColorChangedEvent, value); }
		}

		public event RoutedPropertyChangedEventHandler<Color> PreviewSelectedColorChanged {
			add { AddHandler(PreviewSelectedColorChangedEvent, value); }
			remove { RemoveHandler(PreviewSelectedColorChangedEvent, value); }
		}

		static void OnSelectedColorChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e) {
			var cp = (ColorPicker)obj;
			var args = new RoutedPropertyChangedEventArgs<Color>((Color)e.OldValue, (Color)e.NewValue, PreviewSelectedColorChangedEvent);
			cp.RaiseEvent(args);
			if(!args.Handled)
				cp.RaiseEvent(new RoutedPropertyChangedEventArgs<Color>((Color)e.OldValue, (Color)e.NewValue, SelectedColorChangedEvent));
		}
	}
}
