using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CH07.CookbookMVVM;

namespace CH07.BlogReader.Models {
	public class BlogComment : ObservableObject {
		string _name;
		string _text;
		DateTime _when;

		public string Name {
			get { return _name; }
			set { SetProperty(ref _name, value, () => Name); }
		}

		public string Text {
			get { return _text; }
			set { SetProperty(ref _text, value, () => Text); }
		}

		public DateTime When {
			get { return _when; }
			set { SetProperty(ref _when, value, () => When); }
		}
	}
}
