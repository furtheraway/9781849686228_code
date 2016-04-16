using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CH07.BlogReader.Models;
using CH07.CookbookMVVM;

namespace CH07.BlogReader.ViewModels {
	public class BlogCommentVM : ViewModelBase<BlogComment> {
		public string Text {
			get { return Model.Text; }
			set {
				Model.Text = value;
				OnPropertyChanged("IsCommentOK");
			}
		}

		public string Name {
			get { return Model.Name; }
			set {
				Model.Name = value;
				OnPropertyChanged("IsCommentOK");
			}
		}

		public bool IsCommentOK {
			get { return !string.IsNullOrWhiteSpace(Model.Name) && !string.IsNullOrWhiteSpace(Model.Text); }
		}
	}
}
