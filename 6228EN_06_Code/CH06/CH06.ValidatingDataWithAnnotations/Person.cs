using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CH06.ValidatingDataWithAnnotations {
	class Person : INotifyPropertyChanged {
		protected virtual void OnPropertyChanged(string propName) {
			var pc = PropertyChanged;
			if (pc != null)
				pc(this, new PropertyChangedEventArgs(propName));
		}

		string _name;
		[Required(ErrorMessage = "A name is required"), StringLength(100, MinimumLength = 3, ErrorMessage = "Name must have at least 3 characters")]
		public string Name {
			get { return _name; }
			set {
				ValidateProperty(value, "Name");
				_name = value;
				OnPropertyChanged("Name");
			}
		}

		int _age;
		[Range(1, 120, ErrorMessage = "Age must be a positive integer")]
		public int Age {
			get { return _age; }
			set {
				ValidateProperty(value, "Age");
				_age = value;
				OnPropertyChanged("Age");
			}

		}

		string _email;
		public string Email {
			get { return _email; }
			set {
				_email = value;
				OnPropertyChanged("Email");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void ValidateProperty<T>(T value, string propertyName) {
			Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = propertyName });
		}

	}
}
