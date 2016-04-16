using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CH06.ValidatingData {
	class Person2 : INotifyPropertyChanged, IDataErrorInfo {
		protected virtual void OnPropertyChanged(string propName) {
			var pc = PropertyChanged;
			if(pc != null)
				pc(this, new PropertyChangedEventArgs(propName));
		}

		string _name;
		public string Name {
			get { return _name; }
			set {
				_name = value;
				OnPropertyChanged("Name");
			}
		}

		int _age;
		public int Age {
			get { return _age; }
			set {
				_age = value;
				OnPropertyChanged("Age");
			}

		}


		public event PropertyChangedEventHandler PropertyChanged;

		// never called by WPF
		public string Error {
			get { return null; }
		}

		public string this[string name] {
			get {
				switch(name) {
					case "Name":
						if (string.IsNullOrWhiteSpace(Name))
							return "Name cannot be empty";
						break;

					case "Age":
						if (Age < 1)
							return "Age must be a positive integer";
						break;
				}
				return null;
			}
		}
	}
}
