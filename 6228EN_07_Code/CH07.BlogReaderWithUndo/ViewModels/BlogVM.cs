using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Windows.Input;
using CH07.BlogReader.Commands;
using CH07.BlogReader.Models;
using CH07.CookbookMVVM;
using CH07.BlogReader.Views;
using CH07.CookbookMVVM.Services;

namespace CH07.BlogReader.ViewModels {
	public class BlogVM : ViewModelBase<Blog, MainVM> {
		public BlogVM(Blog blog, MainVM parent)
			: base(blog, parent) {
			var notify = (INotifyCollectionChanged)blog.Posts;
			if(notify != null) {
				notify.CollectionChanged += delegate {
					OnPropertyChanged("Posts");
				};
			}
		}

		public BloggerVM Blogger {
			get { return new BloggerVM { Model = Model.Blogger }; }
		}

		public IDialogService NewPostDialogService { get; set; }

		ICommand _newPostCommand;
		public ICommand NewPostCommand {
			get {
				if(NewPostDialogService == null)
					NewPostDialogService = new StandardDialogService<NewPostWindow>();
				return _newPostCommand ?? (_newPostCommand = new RelayCommand<BlogPost>(post => {
					if(post == null)
						post = new BlogPost();
					var vm = new BlogPostVM { Model = post };
					var dlg = NewPostDialogService;
					dlg.ViewModel = vm;
					if(dlg.ShowDialog() == true) {
						post.When = DateTime.Now;
						var cmd = new ReversibleCommand(Parent.UndoManager, new NewBlogPostCommand(Model));
						cmd.Execute(post);
					}
				}));
			}
		}


		public IEnumerable<BlogPostVM> Posts {
			get { return Model.Posts.Select(post => new BlogPostVM { Model = post }); }
		}
	}
}
