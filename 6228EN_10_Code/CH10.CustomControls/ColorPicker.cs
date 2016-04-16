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
using System.Windows.Controls.Primitives;

namespace CH10.CustomControls {
	[TemplatePart(Name = "PART_RedShape", Type = typeof(Shape))]
	[TemplatePart(Name = "PART_GreenShape", Type = typeof(Shape))]
	[TemplatePart(Name = "PART_BlueShape", Type = typeof(Shape))]
	[TemplatePart(Name = "PART_AlphaShape", Type = typeof(Shape))]
	[TemplatePart(Name = "PART_RedSlider", Type = typeof(RangeBase))]
	[TemplatePart(Name = "PART_GreenSlider", Type = typeof(RangeBase))]
	[TemplatePart(Name = "PART_BlueSlider", Type = typeof(RangeBase))]
	[TemplatePart(Name = "PART_AlphaSlider", Type = typeof(RangeBase))]
	[TemplatePart(Name = "PART_RedText", Type = typeof(TextBlock))]
	[TemplatePart(Name = "PART_GreenText", Type = typeof(TextBlock))]
	[TemplatePart(Name = "PART_BlueText", Type = typeof(TextBlock))]
	[TemplatePart(Name = "PART_AlphaText", Type = typeof(TextBlock))]
	[TemplatePart(Name = "PART_SelectedColor", Type = typeof(SolidColorBrush))]
	public class ColorPicker : Control {
		ColorToBrushConverter _color2brush = new ColorToBrushConverter();
		ColorToDoubleConverter _color2double = new ColorToDoubleConverter();

		static ColorPicker() {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPicker), new FrameworkPropertyMetadata(typeof(ColorPicker)));
		}

		public static readonly DependencyProperty SelectedColorProperty =
			DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorPicker), new UIPropertyMetadata(Colors.Black, OnSelectedColorChanged));

		public Color SelectedColor {
			get { return (Color)GetValue(SelectedColorProperty); }
			set { SetValue(SelectedColorProperty, value); }
		}

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

		public override void OnApplyTemplate() {
			// bind component shapes
			BindShape("PART_RedShape", "r");
			BindShape("PART_GreenShape", "g");
			BindShape("PART_BlueShape", "b");
			BindShape("PART_AlphaShape", "a");

			// bind sliders
			BindSlider("PART_RedSlider", "r");
			BindSlider("PART_GreenSlider", "g");
			BindSlider("PART_BlueSlider", "b");
			BindSlider("PART_AlphaSlider", "a");

			// bind text blocks
			BindText("PART_RedText", "r", "R: {0}");
			BindText("PART_GreenText", "g", "G: {0}");
			BindText("PART_BlueText", "b", "B: {0}");
			BindText("PART_AlphaText", "a", "A: {0}");

			// bind main color
			var solidBrush = GetTemplateChild("PART_SelectedColor") as SolidColorBrush;
			if(solidBrush != null) {
				var binding = new Binding("SelectedColor");
				binding.Source = this;
				BindingOperations.SetBinding(solidBrush, SolidColorBrush.ColorProperty, binding);
			}
		}

		void BindShape(string partName, string parameter) {
			var shape = GetTemplateChild(partName) as Shape;
			if(shape == null) return;

			var binding = new Binding("SelectedColor");
			binding.Source = this;
			binding.Converter = _color2brush;
			binding.ConverterParameter = parameter;
			shape.SetBinding(Shape.FillProperty, binding);
		}

		void BindSlider(string partName, string parameter) {
			var slider = GetTemplateChild(partName) as RangeBase;
			if(slider == null) return;

			slider.Maximum = 255;
			slider.Minimum = 0;

			var binding = new Binding("SelectedColor");
			binding.Source = this;
			binding.Converter = _color2double;
			binding.ConverterParameter = parameter;
			binding.Mode = BindingMode.TwoWay;
			slider.SetBinding(RangeBase.ValueProperty, binding);
		}

		void BindText(string partName, string parameter, string format) {
			var tb = GetTemplateChild(partName) as TextBlock;
			if(tb == null) return;

			var binding = new Binding("SelectedColor");
			binding.Source = this;
			binding.Converter = _color2double;
			binding.ConverterParameter = parameter;
			binding.StringFormat = format;
			tb.SetBinding(TextBlock.TextProperty, binding);
		}
	}
}
