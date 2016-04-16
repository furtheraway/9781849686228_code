using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using CH07.CookbookMVVM;
using System.Collections.ObjectModel;
using CH07.BlogReader.Models;

namespace CH07.BlogReader.ViewModels {
	class MainVM : ViewModelBase<IEnumerable<Blog>> {
		BlogVM _selectedBlog;

		public IEnumerable<BlogVM> Blogs {
			get { return Model.Select(blog => new BlogVM { Model = blog }); }
		}

		public BlogVM SelectedBlog {
			get { return _selectedBlog; }
			set {
				if(SetProperty(ref _selectedBlog, value, () => SelectedBlog))
					OnPropertyChanged("IsSelectedBlog");
			}
		}

		public Visibility IsSelectedBlog {
			get { return SelectedBlog != null ? Visibility.Visible : Visibility.Collapsed; }
		}

		public MainVM(IEnumerable<Blog> blogs) {
			Model = new ObservableCollection<Blog>(blogs);
		}
	}
}
