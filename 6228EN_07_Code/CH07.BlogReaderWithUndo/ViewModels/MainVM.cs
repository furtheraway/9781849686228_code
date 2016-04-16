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
	public class MainVM : ViewModelBase<IEnumerable<Blog>> {
		BlogVM _selectedBlog;
		public UndoManager UndoManager { get; private set; }
		
		public IEnumerable<BlogVM> Blogs {
			get { return Model.Select(blog => new BlogVM(blog, this)); }
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
			UndoManager = new UndoManager();
		}

		ICommand _undoCommand, _redoCommand;

		public ICommand UndoCommand {
			get { return _undoCommand ?? (_undoCommand = new RelayCommand(() => UndoManager.Undo(), () => UndoManager.CanUndo)); }
		}

		public ICommand RedoCommand {
			get { return _redoCommand ?? (_redoCommand = new RelayCommand(() => UndoManager.Redo(), () => UndoManager.CanRedo)); }
		}
	}
}
