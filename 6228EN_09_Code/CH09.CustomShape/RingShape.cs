﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CH09.CustomShape {
	public class RingShape : Shape {
		static RingShape() {
			StretchProperty.OverrideMetadata(typeof(RingShape), new FrameworkPropertyMetadata(Stretch.Uniform, 
				FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		}

		Rect _rect;

		public double RingWidth {
			get { return (double)GetValue(RingWidthProperty); }
			set { SetValue(RingWidthProperty, value); }
		}

		public static readonly DependencyProperty RingWidthProperty =
			 DependencyProperty.Register("RingWidth", typeof(double), typeof(RingShape), new FrameworkPropertyMetadata(.1, FrameworkPropertyMetadataOptions.AffectsRender));



		protected override Geometry DefiningGeometry {
			get {
				if(_rect.IsEmpty)
					return Geometry.Empty;

				var rc = _rect;
				rc.Inflate(-RingWidth * _rect.Width, -RingWidth * _rect.Height);
				return new CombinedGeometry(GeometryCombineMode.Exclude,
					new EllipseGeometry(_rect), new EllipseGeometry(rc));
			}
		}

		protected override Size MeasureOverride(Size constraint) {
			if(double.IsInfinity(constraint.Width) || double.IsInfinity(constraint.Height)) {
				_rect = Rect.Empty;
				return Size.Empty;
			}

			double size;
			switch(Stretch) {
				case Stretch.Fill:
					_rect = new Rect(constraint);
					break;
				case Stretch.Uniform:
					size = Math.Min(constraint.Width, constraint.Height);
					_rect = new Rect(new Size(size, size));
					break;

				case Stretch.UniformToFill:
					size = Math.Max(constraint.Width, constraint.Height);
					_rect = new Rect(new Size(size, size));
					break;

				case Stretch.None:
					_rect = double.IsNaN(Width) || double.IsNaN(Height) ? Rect.Empty : new Rect(new Size(Width, Height));
					break;
			}
			return _rect.Size;
		}
	}

}
