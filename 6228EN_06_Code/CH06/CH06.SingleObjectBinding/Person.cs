using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CH06.SingleObjectBinding {
	class Person : ObservableObject {
		public string Name { get; set; }

		int _age;
		public int Age {
			get { return _age; }
			set { SetProperty(ref _age, value, () => Age); }

		}
	}
}
