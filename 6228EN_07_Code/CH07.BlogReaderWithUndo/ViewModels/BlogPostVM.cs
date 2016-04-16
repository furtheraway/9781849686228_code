using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using CH07.BlogReader.Views;
using CH07.CookbookMVVM;
using CH07.BlogReader.Models;

namespace CH07.BlogReader.ViewModels {
	public class BlogPostVM : ViewModelBase<BlogPost> {
		public string Title {
			get { return Model.Title; }
			set {
				Model.Title = value;
				OnPropertyChanged("IsPostOK");
			}
		}

		public string Text {
			get { return Model.Text; }
			set {
				Model.Text = value;
				OnPropertyChanged("IsPostOK");
			}
		}

		public bool IsPostOK {
			get { return !string.IsNullOrWhiteSpace(Model.Title) && !string.IsNullOrWhiteSpace(Model.Text); }
		}

		ICommand _newCommentCommand;

		public ICommand NewCommentCommand {
			get {
				return _newCommentCommand ?? (_newCommentCommand = new RelayCommand(() => {
					var comment = new BlogComment();
					var dlg = new NewCommentWindow {
						DataContext =
							new BlogCommentVM { Model = comment }
					};
					if(dlg.ShowDialog() == true) {
						comment.When = DateTime.Now;
						Model.Comments.Add(comment);
					}
				}));
			}
		}

	}
}
