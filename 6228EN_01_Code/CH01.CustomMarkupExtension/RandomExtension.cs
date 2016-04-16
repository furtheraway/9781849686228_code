using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Reflection;
using System.Windows;

namespace CH01.CustomMarkupExtension {
	public class RandomExtension : MarkupExtension {
		readonly int _from, _to;

		public RandomExtension(int from, int to) {
			_from = from; _to = to;
		}

		public RandomExtension(int to)
			: this(0, to) {
		}

		static readonly Random _rnd = new Random();
		public override object ProvideValue(IServiceProvider sp) {
			int value = _rnd.Next(_from, _to);
			Type targetType = null;
			if(sp != null) {
				var target = sp.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
				if(target != null) {
					var clrProp = target.TargetProperty as PropertyInfo;
					if(clrProp != null)
						targetType = clrProp.PropertyType;
					if(targetType == null) {
						var dp = target.TargetProperty as DependencyProperty;
						if(dp != null)
							targetType = dp.PropertyType;
					}
				}
			}
			return targetType != null ?
				Convert.ChangeType(value, targetType) :
				value.ToString();
		}
	}
}
