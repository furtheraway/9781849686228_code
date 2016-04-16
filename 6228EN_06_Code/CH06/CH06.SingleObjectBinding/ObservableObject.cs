using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;

namespace CH06.SingleObjectBinding {
	public abstract class ObservableObject : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propName) {
			Debug.Assert(GetType().GetProperty(propName) != null);
			var pc = PropertyChanged;
			if(pc != null)
				pc(this, new PropertyChangedEventArgs(propName));
		}

		protected void SetProperty<T>(ref T field, T value, string propName) {
			if(!EqualityComparer<T>.Default.Equals(field, value)) {
				field = value;
				OnPropertyChanged(propName);
			}
		}

		protected void SetProperty<T>(ref T field, T value, Expression<Func<T>> expr) {
			if(!EqualityComparer<T>.Default.Equals(field, value)) {
				field = value;
				var lambda = (LambdaExpression) expr;
				MemberExpression memberExpr;
				if (lambda.Body is UnaryExpression) {
					var unaryExpr = (UnaryExpression)lambda.Body;
					memberExpr = (MemberExpression) unaryExpr.Operand;
				}
				else {
					memberExpr = (MemberExpression) lambda.Body;
				}

				OnPropertyChanged(memberExpr.Member.Name);
			}
		}


	}
}
