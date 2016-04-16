using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;

namespace CH01.CustomMarkupExtension {
	public class RandomExExtension : MarkupExtension {
		int _from, _to;

		public RandomExExtension(int from, int to) {
			_from = from; _to = to;
		}

		public RandomExExtension(int to)
			: this(0, to) {
		}

		public bool UseFractions { get; set; }

		public TimeSpan UpdateInterval { get; set; }

		static Random _rnd = new Random();

		public override object ProvideValue(IServiceProvider sp) {
			double value = UseFractions ?
				_rnd.NextDouble() * (_to - _from) + _from :
				(double)_rnd.Next(_from, _to);
			Type targetType = null;
			DependencyProperty dp = null;
			PropertyInfo pi = null;
			object targetObject = null;
			if(sp != null) {
				var target = sp.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
				if(target != null) {
					targetObject = target.TargetObject;
					pi = target.TargetProperty as PropertyInfo;
					if(pi != null)
						targetType = pi.PropertyType;
					if(targetType == null) {
						dp = target.TargetProperty as DependencyProperty;
						if(dp != null)
							targetType = dp.PropertyType;
					}
				}
			}
			object finalValue = targetType != null ?
				Convert.ChangeType(value, targetType) :
				value.ToString();
			if(UpdateInterval != TimeSpan.Zero) {
				// setup timer...
				var timer = new DispatcherTimer();
				timer.Interval = UpdateInterval;
				timer.Tick += (sender, e) => {
					value = UseFractions ?
						_rnd.NextDouble() * (_to - _from) + _from :
						(double)_rnd.Next(_from, _to);
					finalValue = targetType != null ?
						Convert.ChangeType(value, targetType) :
						value.ToString();
					if(dp != null)
						((DependencyObject)targetObject).SetValue(dp, finalValue);
					else if(pi != null)
						pi.SetValue(targetObject, value, null);
				};
				timer.Start();
			}
			return finalValue;
		}
	}
}
