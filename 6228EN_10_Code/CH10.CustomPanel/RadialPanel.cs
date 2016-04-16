using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace CH10.CustomPanel {
	public enum SpreadType {
		Complete,
		Incremental,
		Explicit
	}

	public class RadialPanel : Panel {
		protected override Size MeasureOverride(Size availableSize) {
			Size maxSize = Size.Empty;
			foreach(UIElement child in Children) {
				child.Measure(availableSize);
				maxSize = new Size(Math.Max(maxSize.Width, child.DesiredSize.Width), Math.Max(maxSize.Height, child.DesiredSize.Height));
			}

			return new Size(double.IsPositiveInfinity(availableSize.Width) ? maxSize.Width * 2 : availableSize.Width,
				double.IsPositiveInfinity(availableSize.Height) ? maxSize.Height * 2 : availableSize.Height);
		}

		protected override Size ArrangeOverride(Size finalSize) {
			Point center = new Point(finalSize.Width / 2, finalSize.Height / 2);
			var count = Children.Count;

			double angle = StartAngle, final;
			foreach(UIElement element in Children) {
				if(SpreadType == SpreadType.Explicit) {
					double specific = RadialPanel.GetAngle(element);
					if(!double.IsNaN(specific)) angle = StartAngle + specific;
				}
				final = (90 - angle) * Math.PI / 180;
				double radius = RadialPanel.GetRadius(element);
				if(double.IsNaN(radius)) 
					radius = DefaultRadius;
				Rect rc = new Rect(new Point(
					center.X - element.DesiredSize.Width / 2 + (radius * center.X - element.DesiredSize.Width / 2) * Math.Cos(final),
					center.Y - element.DesiredSize.Height / 2 - (radius * center.Y - element.DesiredSize.Height / 2) * Math.Sin(final)),
					element.DesiredSize);
				element.Arrange(rc);

				switch(SpreadType) {
					case SpreadType.Complete:
						angle += 360 / count;
						break;
					case SpreadType.Incremental:
					case SpreadType.Explicit:
						angle += AngleIncrement;
						break;
				}
			}
			return finalSize;
		}

		public SpreadType SpreadType {
			get { return (SpreadType)GetValue(SpreadTypeProperty); }
			set { SetValue(SpreadTypeProperty, value); }
		}

		public double AngleIncrement {
			get { return (double)GetValue(AngleIncrementProperty); }
			set { SetValue(AngleIncrementProperty, value); }
		}

		public double StartAngle {
			get { return (double)GetValue(StartAngleProperty); }
			set { SetValue(StartAngleProperty, value); }
		}

		public double DefaultRadius {
			get { return (double)GetValue(DefaultRadiusProperty); }
			set { SetValue(DefaultRadiusProperty, value); }
		}

		public static readonly DependencyProperty DefaultRadiusProperty =
			 DependencyProperty.Register("DefaultRadius", typeof(double), typeof(RadialPanel), new FrameworkPropertyMetadata(1.0, 
				 FrameworkPropertyMetadataOptions.AffectsRender));
		
		public static readonly DependencyProperty StartAngleProperty =
			 DependencyProperty.Register("StartAngle", typeof(double), typeof(RadialPanel), new FrameworkPropertyMetadata(0.0,
				 FrameworkPropertyMetadataOptions.AffectsRender));

		public static readonly DependencyProperty AngleIncrementProperty =
			 DependencyProperty.Register("AngleIncrement", typeof(double), typeof(RadialPanel), new FrameworkPropertyMetadata(10.0,
				 FrameworkPropertyMetadataOptions.AffectsRender));

		public static readonly DependencyProperty SpreadTypeProperty =
			 DependencyProperty.Register("SpreadType", typeof(SpreadType), typeof(RadialPanel), new FrameworkPropertyMetadata(SpreadType.Complete,
				 FrameworkPropertyMetadataOptions.AffectsRender));

		// attached properties

		[AttachedPropertyBrowsableForChildren]
		public static double GetAngle(DependencyObject obj) {
			return (double)obj.GetValue(AngleProperty);
		}

		[AttachedPropertyBrowsableForChildren]
		public static void SetAngle(DependencyObject obj, double value) {
			obj.SetValue(AngleProperty, value);
		}

		[AttachedPropertyBrowsableForChildren]
		public static double GetRadius(DependencyObject obj) {
			return (double)obj.GetValue(RadiusProperty);
		}

		[AttachedPropertyBrowsableForChildren]
		public static void SetRadius(DependencyObject obj, double value) {
			obj.SetValue(RadiusProperty, value);
		}

		public static readonly DependencyProperty RadiusProperty =
			 DependencyProperty.RegisterAttached("Radius", typeof(double), typeof(RadialPanel), new FrameworkPropertyMetadata(double.NaN, 
				 FrameworkPropertyMetadataOptions.AffectsRender));

		
		public static readonly DependencyProperty AngleProperty =
			 DependencyProperty.RegisterAttached("Angle", typeof(double), typeof(RadialPanel), new FrameworkPropertyMetadata(double.NaN,
				 FrameworkPropertyMetadataOptions.AffectsRender));
	}
}
