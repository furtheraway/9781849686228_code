using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using CH07.RoutedCommands.Commands;

namespace CH07.RoutedCommands {
	class ImageData : INotifyPropertyChanged {
		string _imagePath;
		double _zoom = 1.0;

		public double Zoom {
			get { return _zoom; }
			set {
				_zoom = value;
				OnPropertyChanged("Zoom");
			}
		}

		public string ImagePath {
			get { return _imagePath; }
			set {
				_imagePath = value;
				OnPropertyChanged("ImagePath");
			}
		}

		protected virtual void OnPropertyChanged(string name) {
			var pc = PropertyChanged;
			if(pc != null)
				pc(this, new PropertyChangedEventArgs(name));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		ICommand _openImageFileCommand, _zoomCommand;

		public ICommand OpenImageFileCommand {
			get { return _openImageFileCommand; }
		}

		public ICommand ZoomCommand {
			get { return _zoomCommand; }
		}

		public ImageData() {
			_openImageFileCommand = new OpenImageFileCommand(this);
			_zoomCommand = new ZoomCommand(this);

			// for blendability
			var prop = DesignerProperties.IsInDesignModeProperty;
			bool design = (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
			if(design) {
				ImagePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Sample Pictures\Penguins.jpg";
			}
		}
	}
}
