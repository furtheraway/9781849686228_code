﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CH07.CookbookMVVM;

namespace CH07.BlogReader.Models {
	public class Blogger : ObservableObject {
		string _name;
		string _email;
		Stream _picture;

		public string Name {
			get { return _name; }
			set { SetProperty(ref _name, value, () => Name); }
		}

		public string Email {
			get { return _email; }
			set { SetProperty(ref _email, value, () => Email); }
		}

		public Stream Picture {
			get { return _picture; }
			set { SetProperty(ref _picture, value, () => Picture); }
		}
	}
}
