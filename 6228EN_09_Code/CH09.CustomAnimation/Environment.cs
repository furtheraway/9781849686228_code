using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CH09.CustomAnimation {
class Environment : INotifyPropertyChanged {
	public static double Traction = .95;
	double _gravity;

	public double Gravity {
		get { return _gravity; }
		set { 
			_gravity = value;
			OnPropertyChanged("Gravity");
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	void OnPropertyChanged(string propName) {
		var pc = PropertyChanged;
		if(pc != null)
			pc(this, new PropertyChangedEventArgs(propName));
	}
}
}
